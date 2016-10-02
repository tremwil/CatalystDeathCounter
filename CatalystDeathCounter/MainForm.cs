using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

using Catalyst;
using Catalyst.Memory;
using Catalyst.Input;
using Catalyst.Display;

namespace CatalystDeathCounter
{
    public partial class MainForm : Form
    {
        // Enable drop shadows
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        Label boxToUpdate = null;
        string updateParamName;

        bool gameIsRunning = false;
        bool gameIsLoading = false;
        bool init = true;

        bool respawned = false;

        MemoryManager memory;
        PlayerInfo pinfo;
        GameInfo ginfo;

        Timer mainLoop = new Timer();

        public MainForm()
        {
            memory = new MemoryManager();
            pinfo = new PlayerInfo(memory);
            ginfo = new GameInfo(memory);

            mainLoop.Interval = 50;
            mainLoop.Tick += MainAppLoop;

            if (!Properties.Settings.Default.persistentDeath)
            {
                Properties.Settings.Default.deathCount = 0;
                Properties.Settings.Default.Save();
            }

            Overlay.AddAutoField("deathcount",
                () => Properties.Settings.Default.overlayText + Properties.Settings.Default.deathCount,
                "{0}"
            );

            InitializeComponent();
        }

        #region app loop

        private void MainAppLoop(object sender, EventArgs e)
        {
            if (boxToUpdate != null)
            {
                var keys = InputController.GetPressedKeys();
                if (keys.Length == 0) return;

                var key = keys[0];
                if (key == DIKCode.ESCAPE) // ESC to cancel
                    key = (DIKCode)Properties.Settings.Default[updateParamName];

                Properties.Settings.Default[updateParamName] = (int)key;
                Properties.Settings.Default.Save();
                boxToUpdate.Text = key.ToString();
                boxToUpdate = null;

                InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
                return;
            }

            var p = Process.GetProcessesByName("MirrorsEdgeCatalyst");
            if (p.Length == 0 && gameIsRunning)
            {
                gameIsRunning = false;
                memory.ReleaseProcess();

                init = true;

                GameRunningLabel.Text = "NOT RUNNING";
                GameRunningLabel.ForeColor = Color.Red;

                Overlay.Disable();
            }
            else if (p.Length != 0)
            {
                bool lastIter = false;

                if (!gameIsRunning)
                {
                    gameIsRunning = true;
                    memory.OpenProcess("MirrorsEdgeCatalyst");
                    lastIter = true;
                }

                bool loading = false;
                try
                {
                    loading = ginfo.IsLoading();
                }
                catch (Exception)
                {
                    loading = true;
                }

                if (loading && (!gameIsLoading || lastIter))
                {
                    gameIsLoading = true;
                    GameRunningLabel.ForeColor = Color.Goldenrod;
                    GameRunningLabel.Text = "LOADING";
                }
                else if (!loading && (gameIsLoading || lastIter))
                {
                    respawned = true;
                    gameIsLoading = false;
                    GameRunningLabel.ForeColor = Color.Green;
                    GameRunningLabel.Text = "RUNNING";
                }

                if (!gameIsLoading)
                {
                    if (init)
                    {
                        Overlay.Enable(true);
                        init = false;
                    }

                    ToggleLoop();
                }
            }
        }

        private void ToggleLoop()
        {
            DIKCode otoggle = (DIKCode)Properties.Settings.Default.overlayToggleHotkey;
            DIKCode rtoggle = (DIKCode)Properties.Settings.Default.resetHotkey;

            if (InputController.OnKeyDown(otoggle))
            {
                Overlay.Displaying = !Overlay.Displaying;
            }
            if (InputController.IsKeyPressed(rtoggle))
            {
                Properties.Settings.Default.deathCount = 0;
                Properties.Settings.Default.Save();
            }

            if (pinfo.GetHealth() < 1 && respawned)
            {
                respawned = false;

                Properties.Settings.Default.deathCount++;
                Properties.Settings.Default.Save();

                deathCountLabel.Text = Properties.Settings.Default.deathCount.ToString();
            }
        }

        #endregion

        #region app events

        private void MainForm_Load(object sender, EventArgs e)
        {
            resetInputBox.Click += (o, s) => SetHotkey(resetInputBox, "resetHotkey");
            showInputBox.Click += (o, s) => SetHotkey(showInputBox, "overlayToggleHotkey");

            mainLoop.Start();

            UpdateSettings();
            InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
            InputController.EnableInputHook();
        }

        private void XButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* For some reason the process refuses to close unless I force quit */
            ForceClose();
        }

        private void ForceClose()
        {
            mainLoop.Stop();

            Overlay.Disable();
            InputController.DisableInputHook();
            memory.ReleaseProcess();

            Process.GetCurrentProcess().Kill();
        }

        private void XButton_MouseEnter(object sender, EventArgs e)
        {
            XButton.LinkColor = Color.Red;
        }

        private void XButton_MouseLeave(object sender, EventArgs e)
        {
            XButton.LinkColor = Color.White;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.LinkColor = ForeColor;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.LinkColor = Color.White;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            var res = colorDialog.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                Properties.Settings.Default.overlayColor = colorDialog.Color;
                Properties.Settings.Default.Save();

                Overlay.Color = colorDialog.Color;
                colorBtn.BackColor = colorDialog.Color;
                colorBtn.ForeColor = invertColor(colorDialog.Color);
            }
        }

        private void overlayTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Properties.Settings.Default.overlayText = overlayTextBox.Text;
                Properties.Settings.Default.Save();

                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region enable dragging on borderless form

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        #region settings & hotkeys

        private void UpdateSettings()
        {
            resetInputBox.Text = ((DIKCode)Properties.Settings.Default.resetHotkey).ToString();
            showInputBox.Text = ((DIKCode)Properties.Settings.Default.overlayToggleHotkey).ToString();
            overlayTextBox.Text = Properties.Settings.Default.overlayText;
            persistCheckbox.Checked = Properties.Settings.Default.persistentDeath;
            deathCountLabel.Text = Properties.Settings.Default.deathCount.ToString();

            Overlay.Color = Properties.Settings.Default.overlayColor;
            colorBtn.BackColor = Properties.Settings.Default.overlayColor;
            colorBtn.ForeColor = invertColor(colorBtn.BackColor);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            CancelSetHotkey();

            Properties.Settings.Default.resetHotkey = 62;
            Properties.Settings.Default.overlayText = "DEATHS: ";
            Properties.Settings.Default.overlayToggleHotkey = 61;
            Properties.Settings.Default.overlayColor = Color.Red;
            Properties.Settings.Default.persistentDeath = true;

            UpdateSettings();
        }

        private void SetHotkey(Label box, string paramName)
        {
            if (boxToUpdate != null)
            {
                if (boxToUpdate == box) { return; }
                boxToUpdate.Text = ((DIKCode)Properties.Settings.Default[updateParamName]).ToString();
            }

            InputController.MakeProcessSpecific("CatalystDeathCounter");

            box.Text = "Press a key...";
            boxToUpdate = box;
            updateParamName = paramName;
        }

        private void CancelSetHotkey()
        {
            if (boxToUpdate == null) return;

            boxToUpdate.Text = ((DIKCode)Properties.Settings.Default[updateParamName]).ToString();
            boxToUpdate = null;

            InputController.MakeProcessSpecific("MirrorsEdgeCatalyst");
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            CancelSetHotkey();
        }

        #endregion

        #region checkboxes

        private void persistCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CancelSetHotkey();

            Properties.Settings.Default.persistentDeath = persistCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region utilities

        private Color invertColor(Color c)
        {
            return Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B);
        }

        #endregion
    }
}

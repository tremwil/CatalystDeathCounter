namespace CatalystDeathCounter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.LinkLabel();
            this.XButton = new System.Windows.Forms.LinkLabel();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deathCountLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.NoclipSettimgs = new System.Windows.Forms.Panel();
            this.colorBtn = new System.Windows.Forms.Button();
            this.overlayTextBox = new System.Windows.Forms.TextBox();
            this.showInputBox = new System.Windows.Forms.Label();
            this.resetInputBox = new System.Windows.Forms.Label();
            this.persistCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameRunningLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpacingPanel = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.NoclipSettimgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.XButton);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.ActiveLinkColor = System.Drawing.Color.Red;
            this.Minimize.AutoSize = true;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Minimize.LinkColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(233, -3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 25);
            this.Minimize.TabIndex = 2;
            this.Minimize.TabStop = true;
            this.Minimize.Text = "-";
            this.Minimize.VisitedLinkColor = System.Drawing.Color.White;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // XButton
            // 
            this.XButton.ActiveLinkColor = System.Drawing.Color.Red;
            this.XButton.AutoSize = true;
            this.XButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.XButton.LinkColor = System.Drawing.Color.White;
            this.XButton.Location = new System.Drawing.Point(252, 2);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(21, 20);
            this.XButton.TabIndex = 1;
            this.XButton.TabStop = true;
            this.XButton.Text = "X";
            this.XButton.VisitedLinkColor = System.Drawing.Color.White;
            this.XButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.XButton_LinkClicked);
            this.XButton.MouseEnter += new System.EventHandler(this.XButton_MouseEnter);
            this.XButton.MouseLeave += new System.EventHandler(this.XButton_MouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(233, 13);
            this.title.TabIndex = 0;
            this.title.Text = "ME: Catalyst Death Counter - By tremwil";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Controls.Add(this.NoclipSettimgs);
            this.panel2.Controls.Add(this.GameRunningLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 236);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.deathCountLabel);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(116, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 32);
            this.panel4.TabIndex = 15;
            // 
            // deathCountLabel
            // 
            this.deathCountLabel.AutoSize = true;
            this.deathCountLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathCountLabel.Location = new System.Drawing.Point(69, 4);
            this.deathCountLabel.Name = "deathCountLabel";
            this.deathCountLabel.Size = new System.Drawing.Size(20, 21);
            this.deathCountLabel.TabIndex = 15;
            this.deathCountLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(-2, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Deaths: ";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.ResetBtn.Location = new System.Drawing.Point(11, 185);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(253, 33);
            this.ResetBtn.TabIndex = 13;
            this.ResetBtn.Text = "Reset Settings";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // NoclipSettimgs
            // 
            this.NoclipSettimgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NoclipSettimgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoclipSettimgs.Controls.Add(this.colorBtn);
            this.NoclipSettimgs.Controls.Add(this.overlayTextBox);
            this.NoclipSettimgs.Controls.Add(this.showInputBox);
            this.NoclipSettimgs.Controls.Add(this.resetInputBox);
            this.NoclipSettimgs.Controls.Add(this.persistCheckbox);
            this.NoclipSettimgs.Controls.Add(this.label6);
            this.NoclipSettimgs.Controls.Add(this.label5);
            this.NoclipSettimgs.Controls.Add(this.label4);
            this.NoclipSettimgs.Controls.Add(this.panel3);
            this.NoclipSettimgs.Controls.Add(this.label3);
            this.NoclipSettimgs.Controls.Add(this.label2);
            this.NoclipSettimgs.Location = new System.Drawing.Point(11, 47);
            this.NoclipSettimgs.Name = "NoclipSettimgs";
            this.NoclipSettimgs.Size = new System.Drawing.Size(253, 132);
            this.NoclipSettimgs.TabIndex = 2;
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.Red;
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBtn.ForeColor = System.Drawing.Color.Cyan;
            this.colorBtn.Location = new System.Drawing.Point(137, 85);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(100, 23);
            this.colorBtn.TabIndex = 12;
            this.colorBtn.Text = "Modify...";
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // overlayTextBox
            // 
            this.overlayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.overlayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overlayTextBox.ForeColor = System.Drawing.Color.White;
            this.overlayTextBox.Location = new System.Drawing.Point(137, 46);
            this.overlayTextBox.Name = "overlayTextBox";
            this.overlayTextBox.Size = new System.Drawing.Size(100, 20);
            this.overlayTextBox.TabIndex = 11;
            this.overlayTextBox.Text = "DEATHS: ";
            this.overlayTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.overlayTextBox_KeyDown);
            // 
            // showInputBox
            // 
            this.showInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showInputBox.ForeColor = System.Drawing.Color.White;
            this.showInputBox.Location = new System.Drawing.Point(8, 85);
            this.showInputBox.Name = "showInputBox";
            this.showInputBox.Size = new System.Drawing.Size(100, 20);
            this.showInputBox.TabIndex = 10;
            // 
            // resetInputBox
            // 
            this.resetInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.resetInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resetInputBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetInputBox.ForeColor = System.Drawing.Color.White;
            this.resetInputBox.Location = new System.Drawing.Point(6, 46);
            this.resetInputBox.Name = "resetInputBox";
            this.resetInputBox.Size = new System.Drawing.Size(100, 20);
            this.resetInputBox.TabIndex = 7;
            // 
            // persistCheckbox
            // 
            this.persistCheckbox.AutoSize = true;
            this.persistCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persistCheckbox.ForeColor = System.Drawing.Color.White;
            this.persistCheckbox.Location = new System.Drawing.Point(8, 108);
            this.persistCheckbox.Name = "persistCheckbox";
            this.persistCheckbox.Size = new System.Drawing.Size(152, 19);
            this.persistCheckbox.TabIndex = 6;
            this.persistCheckbox.Text = "Persistent death count";
            this.persistCheckbox.UseVisualStyleBackColor = true;
            this.persistCheckbox.CheckedChanged += new System.EventHandler(this.persistCheckbox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Overlay Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Overlay Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Show in Overlay";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-1, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 2);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reset Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotkeys / Settings";
            // 
            // GameRunningLabel
            // 
            this.GameRunningLabel.AutoSize = true;
            this.GameRunningLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameRunningLabel.ForeColor = System.Drawing.Color.Red;
            this.GameRunningLabel.Location = new System.Drawing.Point(11, 26);
            this.GameRunningLabel.Name = "GameRunningLabel";
            this.GameRunningLabel.Size = new System.Drawing.Size(99, 17);
            this.GameRunningLabel.TabIndex = 1;
            this.GameRunningLabel.Text = "NOT RUNNING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mirror\'s Edge: ";
            // 
            // SpacingPanel
            // 
            this.SpacingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpacingPanel.Location = new System.Drawing.Point(0, 23);
            this.SpacingPanel.Name = "SpacingPanel";
            this.SpacingPanel.Size = new System.Drawing.Size(280, 5);
            this.SpacingPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(280, 263);
            this.Controls.Add(this.SpacingPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MEC: Noclip";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.NoclipSettimgs.ResumeLayout(false);
            this.NoclipSettimgs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel XButton;
        private System.Windows.Forms.LinkLabel Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SpacingPanel;
        private System.Windows.Forms.Label GameRunningLabel;
        private System.Windows.Forms.Panel NoclipSettimgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox persistCheckbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resetInputBox;
        private System.Windows.Forms.Label showInputBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label deathCountLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.TextBox overlayTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}


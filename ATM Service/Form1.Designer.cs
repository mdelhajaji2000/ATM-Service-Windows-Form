namespace ATM_Service
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LogIn_Menu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PinCodeReader = new System.Windows.Forms.MaskedTextBox();
            this.CradNumberReader = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.LogIn_Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Version);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(297, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "ATM-Service";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Version.Location = new System.Drawing.Point(545, 77);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(68, 13);
            this.Version.TabIndex = 9;
            this.Version.Text = "Alpha V1.0.0";
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenuPanel.Controls.Add(this.button3);
            this.MainMenuPanel.Controls.Add(this.button1);
            this.MainMenuPanel.Controls.Add(this.button2);
            this.MainMenuPanel.Controls.Add(this.label4);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 117);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(862, 584);
            this.MainMenuPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SkyBlue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(166, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(519, 86);
            this.button3.TabIndex = 6;
            this.button3.Tag = "         Transactions";
            this.button3.Text = "WithDraw";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SkyBlue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(166, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 86);
            this.button1.TabIndex = 5;
            this.button1.Tag = "         Transactions";
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SkyBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(166, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(519, 86);
            this.button2.TabIndex = 4;
            this.button2.Tag = "         Transactions";
            this.button2.Text = "ToTale Balance";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(123, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(624, 86);
            this.label4.TabIndex = 3;
            this.label4.Text = "Welcome To Bank System - ATM Service";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn_Menu
            // 
            this.LogIn_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogIn_Menu.Controls.Add(this.Next_button);
            this.LogIn_Menu.Controls.Add(this.CancelButton);
            this.LogIn_Menu.Controls.Add(this.groupBox1);
            this.LogIn_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogIn_Menu.Location = new System.Drawing.Point(0, 117);
            this.LogIn_Menu.Name = "LogIn_Menu";
            this.LogIn_Menu.Size = new System.Drawing.Size(862, 584);
            this.LogIn_Menu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PinCodeReader);
            this.groupBox1.Controls.Add(this.CradNumberReader);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(30, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 474);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Informations : ";
            // 
            // PinCodeReader
            // 
            this.PinCodeReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.PinCodeReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinCodeReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinCodeReader.Location = new System.Drawing.Point(304, 338);
            this.PinCodeReader.Mask = "0000";
            this.PinCodeReader.Name = "PinCodeReader";
            this.PinCodeReader.PromptChar = '0';
            this.PinCodeReader.Size = new System.Drawing.Size(178, 75);
            this.PinCodeReader.TabIndex = 6;
            this.PinCodeReader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PinCodeReader.ValidatingType = typeof(int);
            this.PinCodeReader.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // CradNumberReader
            // 
            this.CradNumberReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.CradNumberReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CradNumberReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CradNumberReader.Location = new System.Drawing.Point(90, 164);
            this.CradNumberReader.Mask = "0000-0000-0000-0000";
            this.CradNumberReader.Name = "CradNumberReader";
            this.CradNumberReader.PromptChar = '0';
            this.CradNumberReader.Size = new System.Drawing.Size(636, 75);
            this.CradNumberReader.TabIndex = 5;
            this.CradNumberReader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CradNumberReader.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(33, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(741, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "PIN CODE : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Gray;
            this.label29.Location = new System.Drawing.Point(33, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(741, 63);
            this.label29.TabIndex = 3;
            this.label29.Text = "Bank Card Number : ";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackgroundImage = global::ATM_Service.Properties.Resources._001_close;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(769, 16);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 81);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATM_Service.Properties.Resources._007_atm_card;
            this.pictureBox2.Location = new System.Drawing.Point(212, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CancelButton.FlatAppearance.BorderSize = 3;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(183, 495);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(226, 69);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Next_button
            // 
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next_button.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.Next_button.FlatAppearance.BorderSize = 3;
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.ForeColor = System.Drawing.Color.Cyan;
            this.Next_button.Location = new System.Drawing.Point(441, 495);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(226, 69);
            this.Next_button.TabIndex = 15;
            this.Next_button.Text = "NEXT";
            this.Next_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(862, 701);
            this.Controls.Add(this.LogIn_Menu);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainMenuPanel.ResumeLayout(false);
            this.LogIn_Menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label Version;
        protected System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel MainMenuPanel;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel LogIn_Menu;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox CradNumberReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox PinCodeReader;
        protected System.Windows.Forms.Button button10;
        protected System.Windows.Forms.Button Next_button;
        protected System.Windows.Forms.Button CancelButton;
    }
}


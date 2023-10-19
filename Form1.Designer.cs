namespace Challenge04_577669
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.cbLength = new System.Windows.Forms.CheckBox();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.cbNum = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.cbSpace = new System.Windows.Forms.CheckBox();
            this.pbShow = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(200, 136);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(226, 30);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Strength Checker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(47, 475);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 48);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Exit
            // 
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(379, 475);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(147, 48);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cbLength
            // 
            this.cbLength.AutoSize = true;
            this.cbLength.Location = new System.Drawing.Point(25, 199);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(410, 26);
            this.cbLength.TabIndex = 7;
            this.cbLength.Text = "The password must be at least 8 characters long";
            this.cbLength.UseVisualStyleBackColor = true;
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Location = new System.Drawing.Point(25, 245);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(545, 26);
            this.cbCase.TabIndex = 8;
            this.cbCase.Text = "The password must contain both uppercase and lowercase letters";
            this.cbCase.UseVisualStyleBackColor = true;
            // 
            // cbNum
            // 
            this.cbNum.AutoSize = true;
            this.cbNum.Location = new System.Drawing.Point(25, 289);
            this.cbNum.Name = "cbNum";
            this.cbNum.Size = new System.Drawing.Size(450, 26);
            this.cbNum.TabIndex = 9;
            this.cbNum.Text = "The password must contain at least one numeric digit";
            this.cbNum.UseVisualStyleBackColor = true;
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Location = new System.Drawing.Point(25, 333);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(481, 26);
            this.cbSpecial.TabIndex = 10;
            this.cbSpecial.Text = "The password must contain at least one special character";
            this.cbSpecial.UseVisualStyleBackColor = true;
            // 
            // cbSpace
            // 
            this.cbSpace.AutoSize = true;
            this.cbSpace.Location = new System.Drawing.Point(25, 376);
            this.cbSpace.Name = "cbSpace";
            this.cbSpace.Size = new System.Drawing.Size(366, 26);
            this.cbSpace.TabIndex = 11;
            this.cbSpace.Text = "The password must not contain any spaces";
            this.cbSpace.UseVisualStyleBackColor = true;
            // 
            // pbShow
            // 
            this.pbShow.BackgroundImage = global::Challenge04_577669.Properties.Resources.eye;
            this.pbShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbShow.Location = new System.Drawing.Point(433, 136);
            this.pbShow.Name = "pbShow";
            this.pbShow.Size = new System.Drawing.Size(42, 25);
            this.pbShow.TabIndex = 12;
            this.pbShow.TabStop = false;
            this.pbShow.Click += new System.EventHandler(this.pbShow_Click);
            this.pbShow.MouseLeave += new System.EventHandler(this.pbShow_MouseLeave);
            this.pbShow.MouseHover += new System.EventHandler(this.pbShow_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(212, 475);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 48);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(172, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Incase of a mistake click reset";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.BackColor = System.Drawing.Color.Transparent;
            this.lblStrength.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.Color.White;
            this.lblStrength.Location = new System.Drawing.Point(117, 420);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(237, 33);
            this.lblStrength.TabIndex = 15;
            this.lblStrength.Text = "Password Strength: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(137, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hover around the eye to see password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Challenge04_577669.Properties.Resources._lock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbShow);
            this.Controls.Add(this.cbSpace);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.cbNum);
            this.Controls.Add(this.cbCase);
            this.Controls.Add(this.cbLength);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox cbLength;
        private System.Windows.Forms.CheckBox cbCase;
        private System.Windows.Forms.CheckBox cbNum;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbSpace;
        private System.Windows.Forms.PictureBox pbShow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label label4;
    }
}


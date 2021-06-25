namespace WindowsFormsApplication3
{
    partial class Rregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rregister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Register = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNewUserType = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lkbBack = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.centro3;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 101);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(95, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Register.Location = new System.Drawing.Point(34, 9);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(225, 24);
            this.Register.TabIndex = 0;
            this.Register.Text = "New user registration";
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNewPass.Location = new System.Drawing.Point(11, 180);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(273, 24);
            this.txtNewPass.TabIndex = 12;
            this.txtNewPass.Text = "PASSWORD";
            this.txtNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtNewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPass_MouseDown);
            this.txtNewPass.MouseLeave += new System.EventHandler(this.txtPass_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(10, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "_____________________________________________";
            // 
            // txtNewUser
            // 
            this.txtNewUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNewUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNewUser.Location = new System.Drawing.Point(12, 139);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(272, 24);
            this.txtNewUser.TabIndex = 11;
            this.txtNewUser.Text = "USER";
            this.txtNewUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtNewUser.MouseEnter += new System.EventHandler(this.txtUser_MouseEnter);
            this.txtNewUser.MouseLeave += new System.EventHandler(this.txtUser_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(10, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "_____________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(34, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "User type";
            // 
            // cmbNewUserType
            // 
            this.cmbNewUserType.FormattingEnabled = true;
            this.cmbNewUserType.Items.AddRange(new object[] {
            "Master",
            "Administrator",
            "Manager"});
            this.cmbNewUserType.Location = new System.Drawing.Point(122, 225);
            this.cmbNewUserType.Name = "cmbNewUserType";
            this.cmbNewUserType.Size = new System.Drawing.Size(121, 21);
            this.cmbNewUserType.TabIndex = 15;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnConfirm.Location = new System.Drawing.Point(107, 271);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(71, 29);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Done";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lkbBack
            // 
            this.lkbBack.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.lkbBack.AutoSize = true;
            this.lkbBack.BackColor = System.Drawing.Color.Transparent;
            this.lkbBack.LinkColor = System.Drawing.Color.Gray;
            this.lkbBack.Location = new System.Drawing.Point(9, 305);
            this.lkbBack.Name = "lkbBack";
            this.lkbBack.Size = new System.Drawing.Size(77, 13);
            this.lkbBack.TabIndex = 19;
            this.lkbBack.TabStop = true;
            this.lkbBack.Text = "Back To Login";
            this.lkbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbBack_LinkClicked);
            // 
            // Rregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.orig_480362;
            this.ClientSize = new System.Drawing.Size(297, 341);
            this.Controls.Add(this.lkbBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbNewUserType);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rregister";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rregister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNewUserType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.LinkLabel lkbBack;
    }
}
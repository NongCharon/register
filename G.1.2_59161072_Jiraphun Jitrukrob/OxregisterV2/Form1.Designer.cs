namespace OxregisterV2
{
    partial class Register
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
            this.hidePassword = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.PictureBox();
            this.userNameRegister = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.userRegister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hidePassword
            // 
            this.hidePassword.AutoSize = true;
            this.hidePassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.hidePassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.hidePassword.Location = new System.Drawing.Point(335, 226);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(75, 13);
            this.hidePassword.TabIndex = 23;
            this.hidePassword.Tag = "";
            this.hidePassword.Text = "HidePassword";
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.showPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.showPassword.Location = new System.Drawing.Point(181, 226);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(80, 13);
            this.showPassword.TabIndex = 22;
            this.showPassword.Tag = "";
            this.showPassword.Text = "ShowPassword";
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // signIn
            // 
            this.signIn.Image = global::OxregisterV2.Properties.Resources.sign_in;
            this.signIn.Location = new System.Drawing.Point(184, 255);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(70, 47);
            this.signIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.signIn.TabIndex = 20;
            this.signIn.TabStop = false;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 21;
            // 
            // back
            // 
            this.back.Image = global::OxregisterV2.Properties.Resources.back__1_;
            this.back.Location = new System.Drawing.Point(343, 255);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(72, 47);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 19;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // userNameRegister
            // 
            this.userNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.userNameRegister.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.userNameRegister.Location = new System.Drawing.Point(184, 130);
            this.userNameRegister.MaxLength = 8;
            this.userNameRegister.Name = "userNameRegister";
            this.userNameRegister.Size = new System.Drawing.Size(231, 35);
            this.userNameRegister.TabIndex = 15;
            this.userNameRegister.Text = "Name";
            this.userNameRegister.Click += new System.EventHandler(this.userNameRegister_Click);
            this.userNameRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameRegister_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OxregisterV2.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(184, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // passwordRegister
            // 
            this.passwordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.passwordRegister.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordRegister.Location = new System.Drawing.Point(184, 188);
            this.passwordRegister.MaxLength = 8;
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.PasswordChar = '*';
            this.passwordRegister.Size = new System.Drawing.Size(231, 35);
            this.passwordRegister.TabIndex = 17;
            this.passwordRegister.Text = "Password";
            this.passwordRegister.Click += new System.EventHandler(this.passwordRegister_Click);
            this.passwordRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordRegister_KeyPress);
            // 
            // userRegister
            // 
            this.userRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.userRegister.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.userRegister.Location = new System.Drawing.Point(184, 68);
            this.userRegister.MaxLength = 8;
            this.userRegister.Name = "userRegister";
            this.userRegister.Size = new System.Drawing.Size(231, 35);
            this.userRegister.TabIndex = 13;
            this.userRegister.Text = "User";
            this.userRegister.Click += new System.EventHandler(this.userRegister_Click);
            this.userRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userRegister_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(217, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Member Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OxregisterV2.Properties.Resources.img_01;
            this.pictureBox1.Location = new System.Drawing.Point(20, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 317);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.userNameRegister);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.userRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.signIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hidePassword;
        private System.Windows.Forms.Label showPassword;
        private System.Windows.Forms.PictureBox signIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.TextBox userNameRegister;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.TextBox userRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


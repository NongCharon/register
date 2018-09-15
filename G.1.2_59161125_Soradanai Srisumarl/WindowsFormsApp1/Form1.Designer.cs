namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.RegisterLable = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.cancelPicture = new System.Windows.Forms.PictureBox();
            this.okPicture = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterLable
            // 
            this.RegisterLable.AutoSize = true;
            this.RegisterLable.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.RegisterLable.ForeColor = System.Drawing.Color.LawnGreen;
            this.RegisterLable.Location = new System.Drawing.Point(194, 23);
            this.RegisterLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterLable.Name = "RegisterLable";
            this.RegisterLable.Size = new System.Drawing.Size(176, 48);
            this.RegisterLable.TabIndex = 0;
            this.RegisterLable.Text = "Register";
            this.RegisterLable.Click += new System.EventHandler(this.RegisterLable_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Username.Location = new System.Drawing.Point(154, 94);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(269, 41);
            this.Username.TabIndex = 1;
            this.Username.TabStop = false;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Click += new System.EventHandler(this.Username_Click);
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Password.Location = new System.Drawing.Point(154, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(269, 41);
            this.Password.TabIndex = 2;
            this.Password.TabStop = false;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Click += new System.EventHandler(this.Password_Click_1);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.User.Location = new System.Drawing.Point(154, 258);
            this.User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(269, 41);
            this.User.TabIndex = 3;
            this.User.TabStop = false;
            this.User.Text = "Name";
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // cancelPicture
            // 
            this.cancelPicture.BackColor = System.Drawing.Color.Transparent;
            this.cancelPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPicture.Image = ((System.Drawing.Image)(resources.GetObject("cancelPicture.Image")));
            this.cancelPicture.Location = new System.Drawing.Point(339, 336);
            this.cancelPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelPicture.Name = "cancelPicture";
            this.cancelPicture.Size = new System.Drawing.Size(112, 58);
            this.cancelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelPicture.TabIndex = 5;
            this.cancelPicture.TabStop = false;
            this.cancelPicture.Click += new System.EventHandler(this.cancelPicture_Click);
            // 
            // okPicture
            // 
            this.okPicture.BackColor = System.Drawing.Color.Transparent;
            this.okPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okPicture.Image = ((System.Drawing.Image)(resources.GetObject("okPicture.Image")));
            this.okPicture.Location = new System.Drawing.Point(128, 336);
            this.okPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okPicture.Name = "okPicture";
            this.okPicture.Size = new System.Drawing.Size(124, 58);
            this.okPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.okPicture.TabIndex = 4;
            this.okPicture.TabStop = false;
            this.okPicture.Click += new System.EventHandler(this.okPicture_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(13, 12);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 444);
            this.Controls.Add(this.cancelPicture);
            this.Controls.Add(this.okPicture);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.RegisterLable);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterLable;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.PictureBox okPicture;
        private System.Windows.Forms.PictureBox cancelPicture;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


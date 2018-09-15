using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtComfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                MongoClient client = new MongoClient("mongodb://admin:a123456@ds141902.mlab.com:41902/ox");
                MongoServer server = client.GetServer();
                MongoDatabase database = server.GetDatabase("ox");
                MongoCollection mongoCollection = database.GetCollection<User>("User");
                User user = new User();
                BindingList<User> doclist = new BindingList<User>();
                var getCollection = database.GetCollection<User>("User");
                var insertUser = getCollection.AsQueryable().Where(pd => pd.Username == txtUsername.Text);

                foreach (var p in insertUser)
                {
                    doclist.Add(p);
                    Application.DoEvents();
                }
                dataGridView1.DataSource = doclist;
                if (dataGridView1.Rows.Count == 0)
                {
                    if (!string.IsNullOrEmpty(txtUsername.Text.Trim()) && !txtUsername.Text.Equals("Username"))
                    {
                        user.Username = txtUsername.Text;
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอก Username");
                    }
                    if (!string.IsNullOrEmpty(txtPassword.Text.Trim()) && !txtPassword.Text.Equals("Password"))
                    {
                        user.Password = txtPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอก Password");
                    }
                    if (!string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()) && !txtConfirmPassword.Text.Equals("Confirm Password"))
                    {
                        user.Password = txtConfirmPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอก Comfirm Password");
                    }

                    user.Name = txtUsername.Text;
                    user.Avatar = null;
                    user.Win = 0;
                    user.Draw = 0;
                    user.Lose = 0;

                    if (!string.IsNullOrEmpty(txtUsername.Text.Trim()) &&
                        !string.IsNullOrEmpty(txtPassword.Text.Trim()) &&
                        !string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()) &&
                        (!txtUsername.Text.Equals("Username") &&
                         !txtPassword.Text.Equals("Password") &&
                         !txtConfirmPassword.Text.Equals("Confirm Password")))
                    {
                        if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                        {
                            mongoCollection.Insert(user);
                            MessageBox.Show("สมัครเสร็จสิ้น");
                        }
                        else
                        {
                            MessageBox.Show("กรุณาใส่ Password ให้ตรงกัน");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

    }
}

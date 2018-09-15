using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cancelPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_Click_1(object sender, EventArgs e)
        {
            Password.ForeColor = Color.Black;
            Password.Text = "";
            Password.PasswordChar = '*';
        }

        private void Username_Click(object sender, EventArgs e)
        {
            Username.ForeColor = Color.Black;
            Username.Text = "";
        }

        private void User_Click(object sender, EventArgs e)
        {
            User.ForeColor = Color.Black;
            User.Text = "";
        }

        private void okPicture_Click(object sender, EventArgs e)
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
                var insertUser = getCollection.AsQueryable().Where(pd => pd.Username == Username.Text);

                foreach (var p in insertUser)
                {
                    doclist.Add(p);
                    Application.DoEvents();
                }
                dataGridView1.DataSource = doclist;
                if (dataGridView1.Rows.Count == 0)
                {
                    if (!string.IsNullOrEmpty(Username.Text.Trim()) && !Username.Text.Equals("Username"))
                    {
                        user.Username = Username.Text;
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกUsername");
                    }
                    if (!string.IsNullOrEmpty(Password.Text.Trim()) && !Password.Text.Equals("Password"))
                    {
                        user.Password = Password.Text;
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกPassword");
                    }
                    if (!string.IsNullOrEmpty(User.Text.Trim()) && !User.Text.Equals("Name"))
                    {
                        user.Name = User.Text;
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกName");
                    }
                    user.Avatar = null;
                    user.Win = 0;
                    user.Draw = 0;
                    user.Lose = 0;

                    if (!string.IsNullOrEmpty(Username.Text.Trim()) && 
                        !string.IsNullOrEmpty(Password.Text.Trim()) && 
                        !string.IsNullOrEmpty(User.Text.Trim()) &&
                        (!Username.Text.Equals("Username") &&
                         !Password.Text.Equals("Password") && 
                         !User.Text.Equals("Name")))
                    {
                        mongoCollection.Insert(user);
                        MessageBox.Show("สมัครเสร็จสิ้น");
                    }
                    else
                    {
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
}

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterLable_Click(object sender, EventArgs e)
        {

        }
    }
}

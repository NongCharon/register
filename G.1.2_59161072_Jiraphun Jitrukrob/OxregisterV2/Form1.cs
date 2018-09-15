using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxregisterV2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void userRegister_Click(object sender, EventArgs e)
        {
            userRegister.ForeColor = Color.Black;
            userRegister.Text = "";
        }

        private void userNameRegister_Click(object sender, EventArgs e)
        {
            userNameRegister.ForeColor = Color.Black;
            userNameRegister.Text = "";
        }

        private void passwordRegister_Click(object sender, EventArgs e)
        {
            passwordRegister.ForeColor = Color.Black;
            passwordRegister.Text = "";
        }

        private void userRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 9)
            {

                userRegister.ForeColor = Color.Black;
            }
        }

        private void userNameRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 9)
            {

                userNameRegister.ForeColor = Color.Black;
            }
        }

        private void passwordRegister_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 9)
            {

                passwordRegister.ForeColor = Color.Black;
            }
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordRegister.Text.Length <= 7)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ8ตัว");
            }
            else if (userRegister.Text.Equals("User")|| passwordRegister.Text.Equals("Password")|| userNameRegister.Text.Equals("Name"))
            {
                MessageBox.Show("กรุณากรอบข้อมูลให้ถูกต้อง");
            }

                MongoClient client = new MongoClient("mongodb://admin:a123456@ds141902.mlab.com:41902/ox");
                MongoServer server = client.GetServer();
                MongoDatabase database = server.GetDatabase("ox");
                MongoCollection symbolcollection = database.GetCollection<Register2>("User");
                Register2 register = new Register2();
                BindingList<Register2> doclist = new BindingList<Register2>();
                var registerDB = database.GetCollection<Register2>("User");
                var registerDB2 = registerDB.AsQueryable().Where(pd => pd.Username == userRegister.Text);
                foreach (var p in registerDB2)
                {
                    doclist.Add(p);
                    Application.DoEvents();
                }
                dataGridView1.DataSource = doclist;
                if (dataGridView1.Rows.Count == 0&&(passwordRegister.Text.Length >= 8))
                {
                    register.Username = userRegister.Text;
                    register.Name = userNameRegister.Text;
                    register.Password = passwordRegister.Text;
                    register.Avatar = null;
                   
                    register.Win = 0;
                    register.Draw = 0;
                    register.Lose = 0;
                    symbolcollection.Insert(register);
                    MessageBox.Show("สมัครเรียบร้อย");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex);
            }
        }
        public class Register2
        {
            public ObjectId _id { get; set; }
            public string Username
            {
                get; set;
            }
            public string Name
            {
                get; set;
            }
            public string Password
            {
                get; set;
            }
            public string Avatar
            {
                get; set;
            }
            public Int64 Win
            {
                get; set;
            }
            public Int64 Draw
            {
                get; set;
            }
            public Int64 Lose
            {
                get; set;
            }
        }
        private void showPassword_Click(object sender, EventArgs e)
        {

        
            passwordRegister.PasswordChar = '\0';
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            passwordRegister.PasswordChar = '*';
        }
    }
}

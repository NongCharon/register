using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace WindowsFormsApp1
{
    class User
    {
        public ObjectId _id { get; set; }
        public string Username
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Avatar
        {
            get; set;
        }
        public int Win
        {
            get; set;
        }
        public int Draw
        {
            get; set;
        }
        public int Lose
        {
            get; set;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Blood_Giving.Tables
{
    public class User_TB
    {
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Type_Blood { get; set; }
    }
}

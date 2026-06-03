using System;
using System.Collections.Generic;
using System.Text;

namespace МенеджнрПаролей
{
    public class User
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }   
        public List<PasswordEntry> Passwords { get; set; } = new List<PasswordEntry>();
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace МенеджнрПаролей
{
    public class PasswordEntry
    {
        public string Site {  get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return Site + " - " + Login;  
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace project_smt2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string NamaLengkap { get; set; }
        public string Email { get; set; }
        public string NomorTelepon { get; set; }
        public string Password { get; set; }
        public string RoleUser { get; set; }
    }
}

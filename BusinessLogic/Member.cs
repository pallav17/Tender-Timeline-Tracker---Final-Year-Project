using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Member : IModel
    {
        public int MemberID;
        public string Name;
        public string Email;
        public string Phone;
        public string Username;
        public string Password;
    }
}

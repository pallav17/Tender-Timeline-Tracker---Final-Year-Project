using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Officer : IModel
    {
        public int OfficerID;
        public string Name;
        public string MobileNo;
        public string EmailId;
        public int ProjectID;
        public string Username;
        public string Password;
        public DateTime AllocationTime;
    }
}

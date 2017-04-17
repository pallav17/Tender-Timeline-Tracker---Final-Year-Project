using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
   public class Vendor : IModel
    {
        public int VendorID;
        public string Name;
        public string MobileNo;
        public string EmailId;
        public string Username;
        public string Password;
        public string Photo;
        public int DomainID;
        public string CompanyName;
        public DateTime CreationTime;

    }
}

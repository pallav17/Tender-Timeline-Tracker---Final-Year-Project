using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Tender : IModel
    {
        public int TenderID;
        public int ProjectID;
        public int VendorID;
        public string Details;
        public DateTime CreationTime;
        public string Documents;
        public int ProposedCost;
        public string Status;
        public int Manpower;
        public DateTime EstimatedTime;
    }
}

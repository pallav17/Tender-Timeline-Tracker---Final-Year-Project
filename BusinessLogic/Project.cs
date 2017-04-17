using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Project : IModel
    {
        public int ProjectID;
        public string Name;
        public int DomainID;
        public DateTime CreationTime;
        public DateTime TenderDeadline;
        public DateTime ScheduledStartTime;
        public DateTime ScheduledEndTime;
        public DateTime StartTime;
        public DateTime EndTime;
        public string Budget;
        public string Details;
        public string Documents;
        public string Status;
        public int VendorID;
        public int OfficerID;
    }
}

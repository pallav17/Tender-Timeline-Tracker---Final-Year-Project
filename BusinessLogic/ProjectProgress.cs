using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class ProjectProgress : IModel
    {
        public int ProjectProgressID;
        public int ProjectID;
        public int VendorID;
        public int OfficerID;
        public DateTime ProgressTime;
        public string PercentageCompletion;
        public string Photo;
        public int Latitude;
        public int Longitude;
        
    }
}

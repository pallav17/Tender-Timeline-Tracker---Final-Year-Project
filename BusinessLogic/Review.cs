using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Review : IModel
    {
        public int ReviewID;
        public int OfficerID;
        public int VendorID;
        public DateTime ReviewTime;
        public string ReviewDetails;
        public int Rating;
    }
}

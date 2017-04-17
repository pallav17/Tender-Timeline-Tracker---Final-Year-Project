using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class Product : IModel
    {
        public int ProductID;
        public string Name;
        public float Price;
        public string Photo;
        public string Description;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Service
    {
        private int ServicesID;
        private string Type;
        private decimal Price;
        private string UnitOfMeasure;

        public int servicesid
        {
            get { return ServicesID; }
            set { ServicesID = value; }
        }
        public string type
        {
            get { return type; }
            set { Type = value; }
        }
        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }
        public string measure
        {
            get { return UnitOfMeasure; }
            set { UnitOfMeasure = value; }
        }
    }
}
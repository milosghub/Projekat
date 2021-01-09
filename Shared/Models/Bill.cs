using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
   public class Bill
    {
        private int UserID;
        private int ServicesID;
        private decimal Quantity;


        public int servicesid
        {
            get { return ServicesID; }
            set { ServicesID = value; }
        }

        public int userid
        {
            get { return UserID; }
            set { UserID = value; }
        }

        public decimal quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
    }
}

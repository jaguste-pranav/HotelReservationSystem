using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Customer
    {
        public double rateForCustomer{ get; set; }
        public bool isRegular { get; set; }

        public Customer(CustomerType customer)
        {
            if(customer == CustomerType.REGULAR)
            {
                isRegular = true;
            }
            else
            {
                isRegular = false;
            }
        }

        public double getPriceForDay()
        {
            double rateForDay = this.rateForCustomer;
            return rateForDay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationTest
{
    public class Customer
    {
        public double weekEndRate{ get; set; }
        public double weekDateRate { get; set; }

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
    }
}

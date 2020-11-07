using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationTest
{
    public class Hotel
    {
        public double weekEndRate { get; set; }
        public double weekDayRate { get; set; }

        public Hotel(double weekDayRate, double weekEndRate)
        {
            this.weekDayRate = weekDayRate;
            this.weekEndRate = weekEndRate;
        }
    }
}

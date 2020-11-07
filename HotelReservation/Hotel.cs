using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class Hotel
    {
        public double weekEndRateForRegular { get; set; }
        public double weekDayRateForRegular { get; set; }

        public double weekEndRateForLoyalty { get; set; }
        public double weekDayRateForLoyalty { get; set; }

        public int ratingOfHotel { get; set; }

        public Hotel(Customer customer, double weekDayRate, double weekEndRate)
        {
            if(customer.isRegular)
            {
                this.weekDayRateForRegular = weekDayRate;
                this.weekEndRateForRegular = weekEndRate;
            }
            else 
            {
                this.weekDayRateForLoyalty = weekDayRate;
                this.weekEndRateForLoyalty = weekEndRate;
            }
        }

        public void setRatingForHotel(int rating)
        {
            this.ratingOfHotel = rating;
        }
    }
}

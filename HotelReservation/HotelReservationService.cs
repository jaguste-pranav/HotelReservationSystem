using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class HotelReservationService
    {
        public string getCheapestHotel(Customer customer, List<Hotel> hotels, string[] dates)
        {
            string output = "";
            double minRate;

            double rateForBridgeWood = 0;
            double rateForRidgeWood = 0;
            double rateForLakeWood = 0;

            if (customer.isRegular)
            {
                foreach (string date in dates)
                {

                    if (isWeekEnd(date))
                    {

                        rateForBridgeWood = rateForBridgeWood + hotels[0].weekEndRateForRegular;
                        rateForRidgeWood = rateForRidgeWood + hotels[1].weekEndRateForRegular;
                        rateForLakeWood = rateForLakeWood + hotels[2].weekEndRateForRegular;
                    }
                    else
                    {

                        rateForBridgeWood = rateForBridgeWood + hotels[0].weekDayRateForRegular;
                        rateForRidgeWood = rateForRidgeWood + hotels[1].weekDayRateForRegular;
                        rateForLakeWood = rateForLakeWood + hotels[2].weekDayRateForRegular;

                    }

                }

                if (rateForBridgeWood < rateForLakeWood && rateForBridgeWood < rateForRidgeWood)
                {
                    output = "Hotel: BridgeWood, Rate: " + rateForBridgeWood;
                }
                if (rateForRidgeWood < rateForLakeWood && rateForRidgeWood < rateForBridgeWood)
                {
                    output = "Hotel: RidgeWood, Rate: " + rateForRidgeWood;
                }
                if (rateForLakeWood < rateForBridgeWood && rateForLakeWood < rateForRidgeWood)
                {
                    output = "Hotel: LakeWood, Rate: " + rateForLakeWood;
                }
            }
            else
            {
                foreach (string date in dates)
                {
                    string day = DateTime.Parse(date.ToString()).DayOfWeek.ToString();
                    if (isWeekEnd(day))
                    {
                        rateForBridgeWood = rateForBridgeWood + hotels[0].weekEndRateForLoyalty;
                        rateForRidgeWood = rateForRidgeWood + hotels[1].weekEndRateForLoyalty;
                        rateForLakeWood = rateForLakeWood + hotels[2].weekEndRateForLoyalty;
                    }
                    else
                    {
                        Console.WriteLine("Inside: " + hotels[0].weekEndRateForRegular);
                        rateForBridgeWood = rateForBridgeWood + hotels[0].weekDayRateForRegular;
                        rateForRidgeWood = rateForRidgeWood + hotels[1].weekDayRateForRegular;
                        rateForLakeWood = rateForLakeWood + hotels[2].weekDayRateForRegular;
                    }
                }

                if (rateForBridgeWood < rateForLakeWood && rateForBridgeWood < rateForRidgeWood)
                {
                    output = "Hotel: BridgeWood, Rate: " + rateForBridgeWood;
                }
                if (rateForRidgeWood < rateForLakeWood && rateForRidgeWood < rateForBridgeWood)
                {
                    output = "Hotel: RidgeWood, Rate: " + rateForRidgeWood;
                }
                if (rateForLakeWood < rateForBridgeWood && rateForLakeWood < rateForRidgeWood)
                {
                    output = "Hotel: LakeWood, Rate: " + rateForLakeWood;
                }
            }

            return output;
        }

        public double getWeekDayRateForRegular(Hotel hotel)
        {
            return hotel.weekDayRateForRegular;
        }

        public double getWeekEndRateForRegular(Hotel hotel)
        {
            return hotel.weekEndRateForRegular;
        }

        public double getWeekDayRateForLoyalty(Hotel hotel)
        {
            return hotel.weekDayRateForLoyalty;
        }

        public double getWeekEndRateForLoyalty(Hotel hotel)
        {
            return hotel.weekDayRateForLoyalty;
        }

        public bool isWeekEnd(string date)
        {
            string day = DateTime.Parse(date.ToString()).DayOfWeek.ToString();
            if (day.Equals("Sunday") || day.Equals("Saturday"))
            {
                return true;
            }
            return false;
        }

        public string getCheapestBestRatedHotel(Customer customer, List<Hotel> hotels, string[] dates)
        {
            string cheapestHotel = getCheapestHotel(customer, hotels, dates);
            string output = "";
            if (cheapestHotel.ToLower().Contains("bridgewood"))
            {
                output = cheapestHotel + " Rating: " + hotels[0].ratingOfHotel;
            }

            if (cheapestHotel.ToLower().Contains("ridgewood"))
            {
                output = cheapestHotel +" Rating: " + hotels[1].ratingOfHotel;
            }

            if (cheapestHotel.ToLower().Contains("lakewood"))
            {
                output = cheapestHotel + " Rating: " + hotels[2].ratingOfHotel;
            }

            return output;
        }
    }
}

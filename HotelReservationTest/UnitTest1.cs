using NUnit.Framework;
using System.Collections.Generic;
using HotelReservation;

namespace HotelReservationTest
{
    public class Tests
    {
        List<Hotel> hotels = new List<Hotel>();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void GivenHotelNames_AddHotels()
        {
            Customer customer = new Customer(CustomerType.REGULAR);

            Hotel BridgeWood = new Hotel(customer, 160, 60);
            Hotel RidgeWood = new Hotel(customer, 220, 150);
            Hotel LakeWood = new Hotel(customer, 110, 90);

            hotels.Add(BridgeWood);
            hotels.Add(RidgeWood);
            hotels.Add(LakeWood);

            int countOfHotels = 3;
            int countOfHotelsinList = hotels.Count;
            Assert.AreEqual(countOfHotels, countOfHotelsinList);
        }

        [Test]
        public void GivenHotelNames_ReturnCheapestHotel()
        {
            Customer customer = new Customer(CustomerType.REGULAR);
            string[] dates = { "2020-10-01", "2020-10-02" };
            HotelReservationService reservation = new HotelReservationService();
            string output = reservation.getCheapestHotel(customer, hotels, dates);
            Assert.AreEqual(output, "Hotel: LakeWood, Rate: 220");
        }
        public void GivenHotelNames_SetNewRates()
        {
            List<Hotel> hotelsWithNewRate = new List<Hotel>();
            Customer customer = new Customer(CustomerType.REGULAR);

            Hotel BridgeWood = new Hotel(customer, 150, 50);
            Hotel RidgeWood = new Hotel(customer, 220, 150);
            Hotel LakeWood = new Hotel(customer, 110, 90);

            hotelsWithNewRate.Add(BridgeWood);
            hotelsWithNewRate.Add(RidgeWood);
            hotelsWithNewRate.Add(LakeWood);

            int countOfHotels = 3;
            int countOfHotelsinList = hotelsWithNewRate.Count;
            Assert.AreEqual(countOfHotels, countOfHotelsinList);
        }
    }
}
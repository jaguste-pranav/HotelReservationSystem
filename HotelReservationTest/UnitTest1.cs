using NUnit.Framework;
using System.Collections.Generic;

namespace HotelReservationTest
{
    public class Tests
    {
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

            Hotel BridgeWood = new Hotel(160, 60);
            Hotel RidgeWood = new Hotel(220, 150);
            Hotel LakeWood = new Hotel(110, 90);

            List<Hotel> hotel = new List<Hotel>();
            hotel.Add(BridgeWood);
            hotel.Add(RidgeWood);
            hotel.Add(LakeWood);

            int countOfHotels = 3;
            int countOfHotelsinList = hotel.Count;
            Assert.AreEqual(countOfHotels, countOfHotelsinList);
        }
    }
}
using NUnit.Framework;
using System.Collections.Generic;
using HotelReservation;

namespace HotelReservationTest
{
    public class Tests
    {
        List<Hotel> hotels = new List<Hotel>();
        List<Hotel> hotelsWithNewRate = new List<Hotel>();
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
        [Test]
        public void GivenHotelNames_SetNewRates()
        {

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
        [Test]
        public void GivenWeekDayandWeekEnd_ReturnCheapestHotel()
        {
            Customer customer = new Customer(CustomerType.REGULAR);
            string[] dates = { "11-09-2020", "12-09-2020" };
            HotelReservationService reservation = new HotelReservationService();
            string output = reservation.getCheapestHotel(customer, hotels, dates);
            Assert.AreEqual(output, "Hotel: LakeWood, Rate: 200");
        }

        [Test]
        public void GivenWeekDayandWeekEnd_ReturnCheapestHotel_SadCase()
        {
            Customer customer = new Customer(CustomerType.REGULAR);
            string[] dates = { "11-09-2020", "12-09-2020" };
            HotelReservationService reservation = new HotelReservationService();
            string output = reservation.getCheapestHotel(customer, hotels, dates);
            Assert.AreEqual(output, "Hotel: LakeWood, Rate: 210");
        }

        [Test]
        public void GivenRating_SetRatingToHotel()
        {
            hotels[0].setRatingForHotel(4);
            int ratingForBridgewood = 4;
            Assert.AreEqual(ratingForBridgewood, hotels[0].ratingOfHotel);
        }
        [Test]
        public void Givendates_GetCheapestBestRatedHotel()
        {
            Customer customer = new Customer(CustomerType.REGULAR);

            Hotel BridgeWood = new Hotel(customer, 160, 60);
            Hotel RidgeWood = new Hotel(customer, 220, 150);
            Hotel LakeWood = new Hotel(customer, 110, 90);

            hotels.Add(BridgeWood);
            hotels.Add(RidgeWood);
            hotels.Add(LakeWood);

            hotels[0].setRatingForHotel(4);
            hotels[1].setRatingForHotel(5);
            hotels[2].setRatingForHotel(3);

            string[] dates = { "11-09-2020", "12-09-2020" };
            HotelReservationService reservation = new HotelReservationService();
            string output = reservation.getCheapestBestRatedHotel(customer, hotels, dates);
            Assert.AreEqual("Hotel: LakeWood, Rate: 200, Rating: 3", output);
        }

        [Test]
        public void Givendates_GetHighestRatedHotel()
        {
            Customer customer = new Customer(CustomerType.REGULAR);

            Hotel BridgeWood = new Hotel(customer, 160, 60);
            Hotel RidgeWood = new Hotel(customer, 220, 150);
            Hotel LakeWood = new Hotel(customer, 110, 90);

            hotels.Add(BridgeWood);
            hotels.Add(RidgeWood);
            hotels.Add(LakeWood);

            hotels[0].setRatingForHotel(4);
            hotels[1].setRatingForHotel(5);
            hotels[2].setRatingForHotel(3);

            string[] dates = { "11-09-2020", "12-09-2020" };
            HotelReservationService reservation = new HotelReservationService();
            string output = reservation.getHighestRatedHotel(customer, hotels, dates);
            Assert.AreEqual("Hotel: RidgeWood, Rate: 370, Rating: 5", output);
        }

        [Test]
        public void GivenRewardRate_SetRatesToHotels()
        {
            Customer customer = new Customer(CustomerType.REWARD);
            List<Hotel> rewardCustomerHotelList = new List<Hotel>();
            Hotel BridgeWood = new Hotel(customer, 110, 50);
            Hotel RidgeWood = new Hotel(customer, 100, 40);
            Hotel LakeWood = new Hotel(customer, 80, 80);

            rewardCustomerHotelList.Add(BridgeWood);
            rewardCustomerHotelList.Add(RidgeWood);
            rewardCustomerHotelList.Add(LakeWood);

            double weekEndRateForRewardConstumerRidgewood = 40;
            double actual = rewardCustomerHotelList[1].weekEndRateForLoyalty;
            Assert.AreEqual(weekEndRateForRewardConstumerRidgewood, actual);
        }
        [Test]
        public void GivenWeekDayandWeekEnd_ReturnCheapestHotelRewardCustomer()
        {
            List<Hotel> RewardCustomersHotelList = new List<Hotel>();
            Customer customer = new Customer(CustomerType.REWARD);

            Hotel BridgeWood = new Hotel(customer, 160, 60);
            Hotel RidgeWood = new Hotel(customer, 220, 150);
            Hotel LakeWood = new Hotel(customer, 110, 90);

            RewardCustomersHotelList.Add(BridgeWood);
            RewardCustomersHotelList.Add(RidgeWood);
            RewardCustomersHotelList.Add(LakeWood);

            RewardCustomersHotelList[0].setRatingForHotel(4);
            RewardCustomersHotelList[1].setRatingForHotel(5);
            RewardCustomersHotelList[2].setRatingForHotel(3);

            string[] dates = { "12-09-2020", "13-09-2020" };
            HotelReservationService reservation = new HotelReservationService();
            string output = reservation.getCheapestBestRatedHotel(customer, hotels, dates);
            Assert.AreEqual("Hotel: Ridgewood, Rate: 140, Rating: 5", output);
        }
    }
}
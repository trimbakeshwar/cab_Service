using cabService;
using NUnit.Framework;

namespace TestForCabServices
{
    public class Tests
    {
        
        
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// total pay for single rides
        /// </summary>
        [Test]

        public void TestForTotalFairForNormalRide()
        {
            //check for single cap services
            CabService service = new CabService(10, 15,0,"suraj");
            //total pay for single ride
            int totalpay = service.getTotalFair();
            //if equel the pass
            Assert.AreEqual(115, totalpay);
        }
        /// <summary>
        /// total pay for single rides
        /// </summary>
        [Test]

        public void TestForTotalFairForPremiumRide()
        {
            //check for single cap services
            CabService service = new CabService(10, 15, 1, "suraj");
            //total pay for single ride
            int totalpay = service.getTotalFair();
            //if equel the pass
            Assert.AreEqual(180, totalpay);
        }
     

        /// <summary>
        /// check for total amount
        /// </summary>
        [Test]
        public void TestForMultipleRidesTotalFair()
        {
            //array of distance
            int[] dist = { 10, 10, 10, 10 };
            //array of minutes
            int[] min = { 15, 15, 15, 15 };
            //primium or normal is store in list
            int[] forPremiumorNormal = { 1, 0, 1, 1, 0 };
            //user id store in list
            string[] id = { "suraj", "dhiraj", "suraj", "suraj", };
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min, forPremiumorNormal, id);
            //total amount of multiple rides
            int totalAmunt = ride.totalFair;
            Assert.AreEqual(655, totalAmunt);


        }
        /// <summary>
        /// check for avg amount
        /// </summary>
        [Test]
        public void TestForMultipleRidesAggregateFair()
        {

            //array of distance
            int[] dist = { 10, 10, 10, 10 };
            //array of minutes
            int[] min = { 15, 15, 15, 15 };
            //primium or normal is store in list
            int[] forPremiumorNormal = { 1, 0, 1, 1, 0 };
            //user id store in list
            string[] id = { "suraj", "dhiraj", "suraj", "suraj", };
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min, forPremiumorNormal, id);
            //avg amount
            int avgamount = ride.aggregateOfTotalFair;
            Assert.AreEqual(163, avgamount);
        }
        /// <summary>
        /// check for number of rides
        /// </summary>
        [Test]
        public void TestForMultipleRidesNumberOfRides()
        {
            //array of distance
            int[] dist = { 10, 10, 10, 10 };
            //array of minutes
            int[] min = { 15, 15, 15, 15 };
            //primium or normal is store in list
            int[] forPremiumorNormal = { 1, 0, 1, 1, 0 };
            //user id store in list
            string[] id = { "suraj", "dhiraj", "suraj", "suraj", };
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min, forPremiumorNormal, id);
            //total number of rides
            int totalride = ride.TotalNumberOfRides;
            //check with expected output
            Assert.AreEqual(4, totalride);

        }
        /// <summary>
        /// test for number of rides according to user
        /// </summary>
        [Test]
        public void TestForMultipleRidesNumberOfRidesOfUser()
        {
            //array of distance
            int[] dist = { 10, 10, 10, 10 };
            //array of minutes
            int[] min = { 15, 15, 15, 15 };
            //primium or normal is store in list
            int[] forPremiumorNormal = { 1, 0, 1, 1, 0 };
            //user id store in list
            string[] id = { "suraj", "dhiraj", "suraj", "suraj", };
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min, forPremiumorNormal, id);
            //total number of rides
            var CountRides = ride.getAllRides("suraj");
            int totalride = CountRides.Item2;
            //check with expected output
            Assert.AreEqual(3, totalride);

        }
    }
}
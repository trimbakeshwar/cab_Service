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

        public void TestForTotalFair()
        {
            //check for single cap services
            CabService service = new CabService(10, 15);
            //total pay for single ride
            int totalpay = service.getTotalFair();
            //if equel the pass
            Assert.AreEqual(115, totalpay);
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
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min);
            //total amount of multiple rides
            int totalAmunt = ride.totalFair;
            Assert.AreEqual(460, totalAmunt);


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
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min);
            //avg amount
            int avgamount = ride.aggregateOfTotalFair;
            Assert.AreEqual(115, avgamount);
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
            //create constructor for initialize and operaton
            MultipleRide ride = new MultipleRide(dist, min);
            //total number of rides
            int totalride = ride.TotalNumberOfRides;
            //check with expected output
            Assert.AreEqual(4, totalride);

        }
    }
}
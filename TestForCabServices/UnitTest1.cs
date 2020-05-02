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
            
            CabService service = new CabService(10, 15);
            int totalpay = service.getTotalFair();
            Assert.AreEqual(115, totalpay);
        }
        /// <summary>
        /// check for total amount
        /// </summary>
        [Test]
        public void TestForMultipleRidesTotalFair()
        {
            int[] dist = { 10, 10, 10, 10 };
            int[] min = { 15, 15, 15, 15 };
            MultipleRide ride = new MultipleRide(dist, min);
            int totalAmunt = ride.totalFair;
            Assert.AreEqual(460, totalAmunt);


        }
        /// <summary>
        /// check for avg amount
        /// </summary>
        [Test]
        public void TestForMultipleRidesAggregateFair()
        {
            int[] dist = { 10, 10, 10, 10 };
            int[] min = { 15, 15, 15, 15 };
            MultipleRide ride = new MultipleRide(dist, min);
            int avgamount = ride.aggregateOfTotalFair;
            Assert.AreEqual(115, avgamount);
        }
        /// <summary>
        /// check for number of rides
        /// </summary>
        [Test]
        public void TestForMultipleRidesNumberOfRides()
        {
            int[] dist = { 10, 10, 10, 10 };
            int[] min = { 15, 15, 15, 15 };
            MultipleRide ride = new MultipleRide(dist, min);
            int totalride = ride.TotalNumberOfRides;
            Assert.AreEqual(4, totalride);

        }
    }
}
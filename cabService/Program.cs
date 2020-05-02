using System;

namespace cabService
{
    class Program
    {
        static void Main(string[] args)
        {
            CabService service = new CabService(10, 15);
            CabService service2 = new CabService(10, 15);
            CabService service3 = new CabService(10, 15);
            CabService service4 = new CabService(10, 15);
            CabService service5 = new CabService(10, 15);
            int[] dist = { 10, 10, 10, 10 };
            int[] min =  { 15, 15, 15, 15 };
            MultipleRide ride = new MultipleRide(dist, min);
            int totalAmunt = ride.totalFair;
            int avgamount = ride.aggregateOfTotalFair;
            int totalride = ride.TotalNumberOfRides;
            int totalpay = service.getTotalFair();
            Console.WriteLine("total pay : " + totalAmunt+"\n avg pay : "+ avgamount+"\n total rides : " + totalride);
        }
    }
}

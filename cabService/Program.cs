using System;

namespace cabService
{
    class Program
    {
        static void Main(string[] args)
        {
            CabService service = new CabService(10, 15,1,"suraj");
            int totalpay = service.getTotalFair();
            Console.WriteLine("total pay : " + totalpay);
          CabService service2 = new CabService(10, 15,0, "suraj");
             totalpay = service2.getTotalFair();
            Console.WriteLine("total pay : " + totalpay);
            CabService service3 = new CabService(10, 15,1, "dhiraj");
            totalpay = service3.getTotalFair();
            Console.WriteLine("total pay : " + totalpay);
            CabService service4 = new CabService(10, 15,1, "suraj");
            totalpay = service4.getTotalFair();
            Console.WriteLine("total pay : " + totalpay);
            CabService service5 = new CabService(10, 15,3, "dhiraj");
            totalpay = service5.getTotalFair();
            Console.WriteLine("total pay : " + totalpay);
            int[] dist = { 10, 10, 10, 10 };
            int[] min =  { 15, 15, 15, 15 };
            int[] forPremiumorNormal = { 1, 0, 1, 1, 0 };
            string[] id = { "suraj", "dhiraj", "suraj", "suraj", };
            MultipleRide ride = new MultipleRide(dist, min, forPremiumorNormal,id);
            int totalAmunt = ride.totalFair;
            int avgamount = ride.aggregateOfTotalFair;
            int totalride = ride.TotalNumberOfRides;
            //int totalpay = service.getTotalFair();
            Console.WriteLine("total pay : " + totalAmunt+"\n avg pay : "+ avgamount+"\n total rides : " + totalride);
        }
    }
}

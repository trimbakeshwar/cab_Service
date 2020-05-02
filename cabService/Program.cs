using System;

namespace cabService
{
    class Program
    {
        static void Main(string[] args)
        {
            CabService service = new CabService(10, 15);
            int totalpay = service.getTotalFair();
            Console.WriteLine("total pay : " + totalpay);
        }
    }
}

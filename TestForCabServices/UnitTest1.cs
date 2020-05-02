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

        [Test]
        public void TestForTotalFair()
        {
            
            CabService service = new CabService(10, 15);
            int totalpay = service.getTotalFair();
            Assert.AreEqual(115, totalpay);
        }
      
    }
}
using DataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class FlightRepoTest
    {
        [TestMethod]
        public void CreateFlights()
        {
            var repo = new FlightRepository();
            Assert.AreEqual(repo.GetFlights().Count, 10);
        }
    }
}

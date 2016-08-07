using DataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class GateRepoTest
    {
        [TestMethod]
        public void CreateGates()
        {
            var repo = new GateRepository();
            Assert.AreEqual(repo.GetGates().Count, 2);
        }
    }
}

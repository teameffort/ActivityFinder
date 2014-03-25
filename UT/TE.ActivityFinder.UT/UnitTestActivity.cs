using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TE.ActivityFinder.UT
{
    [TestClass]
    public class UnitTestActivity
    {
        [TestMethod]
        public void TestMethod_act_GetActivities()
        {
            var result = new ActivityFinder.BLL.ActivityBLL().act_GetActivities();
            Assert.IsTrue(result.Count > 0);
        }
    }
}

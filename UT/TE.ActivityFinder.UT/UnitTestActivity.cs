using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TE.ActivityFinder.UT
{
    [TestClass]
    public class UnitTestActivity
    {
        [TestMethod]
        public void TestMethod_act_GetActivitiesBLL()
        {
            var result = new ActivityFinder.BLL.ActivityBLL().act_GetActivities();
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void TestMethod_act_GetActivityByIdBLL()
        {
            var result = new ActivityFinder.BLL.ActivityBLL().act_GetActivityById(3);
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void TestMethod_loc_InsertLocationBLL()
        {
            var result = new ActivityFinder.BLL.ActivityBLL().loc_InsertLocation("TestLocation","1","2");
            Assert.IsTrue(result);
        }
    }
}

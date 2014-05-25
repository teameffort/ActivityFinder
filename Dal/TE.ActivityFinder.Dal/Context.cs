using System;
using System.Configuration;

namespace Te.ActivityFinder.Dal
{
    public class Context : IDisposable
    {

        #region Properties

        private static string connectionString;
        public static string ConnectionString
        {
            get
            {
                if (connectionString == null) 
                {
                    connectionString = ConfigurationManager.ConnectionStrings["Te.ActivityFinder.DAL.Properties.Settings.TE_ActivityFinder_DBConnectionString"].ConnectionString;
                }
                return connectionString; 
            }
        }

        private ActivityDataContext activity;
        public ActivityDataContext Activity
        {
            get
            {
                if (activity == null)
                {
                    activity = new ActivityDataContext(ConnectionString);
                }
                return activity;
            }
            set
            {
                activity = value;
            }
        }

        #endregion

        #region IDisposable Implementation

        public void Dispose()
        {
            if (activity != null)
            {
                activity.Dispose();
            }
        }

        #endregion

    }
}

using System;
using System.Configuration;

namespace TE.ActivityFinder.DAL
{
    public class Context : IDisposable
    {

        #region Properties

        private static string _connectionString;
        public static string ConnectionString
        {
            get
            {
                if (_connectionString == null) 
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["TE.ActivityFinder.DAL.Properties.Settings.TE_ActivityFinder_DBConnectionString"].ConnectionString;
                }
                return _connectionString; 
            }
        }

        private ActivityDataContext _activity;
        public ActivityDataContext Activity
        {
            get
            {
                if (_activity == null)
                {
                    _activity = new ActivityDataContext(ConnectionString);
                }
                return _activity;
            }
            set
            {
                _activity = value;
            }
        }

        #endregion

        #region IDisposable Implementation

        public void Dispose()
        {
            if (_activity != null)
            {
                _activity.Dispose();
            }
        }

        #endregion

    }
}

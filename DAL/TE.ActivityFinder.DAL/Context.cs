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
                    _connectionString = ConfigurationManager.ConnectionStrings["TE.ActivityFinder.POC.DAL.Properties.Settings.TE_ActivityFinder_POC_DBConnectionString"].ConnectionString;
                }
                return _connectionString; 
            }
        }

        private PocDataContext _poc;
        public PocDataContext Poc
        {
            get
            {
                if (_poc == null)
                {
                    _poc = new PocDataContext(ConnectionString);
                }
                return _poc;
            }
            set
            {
                _poc = value;
            }
        }

        #endregion

        #region IDisposable Implementation

        public void Dispose()
        {
            if (_poc != null)
            {
                _poc.Dispose();
            }
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAL
{
    public class App
    {
        public string LoginID { get; set; }
        public int ApplicationID { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationType { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CustomerCount { get; set; }

        public App(string loginID, int appID, string appName, string appType, DateTime releaseDate, int customerCount)
        {
            LoginID = loginID;
            ApplicationID = appID;
            ApplicationName = appName;
            ApplicationType = appType;
            ReleaseDate = releaseDate;
            CustomerCount = customerCount;

        }
    }
}

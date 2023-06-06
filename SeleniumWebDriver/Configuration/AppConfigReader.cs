using SeleniumWebDriver.Interfaces;
using SeleniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Configuration
{
    public class AppConfigReader : IConfig
    {

        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);

        }

        public String  GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);

        }

        public String GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);

        }






    }
}

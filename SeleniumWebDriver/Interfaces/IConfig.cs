using SeleniumWebDriver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Interfaces
{
    internal interface IConfig
    {
           BrowserType GetBrowser();
        
       //   throw new NotImplementedException();
        

        String GetUsername();
       // return ConfigurationManager.
        String GetPassword();

    }
}

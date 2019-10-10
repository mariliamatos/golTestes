using System;
using System.Collections.Generic;
using System.Text;


using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System.Threading;

namespace GolVoo.Test
{
    class WebDriver
    {
        public static IWebDriver driver;
        
        public IWebDriver GetWebDriver()
        {
            if (driver==null)
            {
                String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                path = path + "\\..\\..\\Drivers";
                driver = new ChromeDriver(path);
                return driver;
            }
            return driver;

        }


    }
}

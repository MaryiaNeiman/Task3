using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Configuration;

namespace Task3_2
{
    class ClassForWebDriver
    {
       public string ReadBrowser()
        {
            String browser = ConfigurationManager.AppSettings["Browser"];
            Console.WriteLine(browser);
            return "qq";
        }
    }
}

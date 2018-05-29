using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicarion1
{
    class SetMethods
    {
        public static void entertext( IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        public static void click(IWebElement element)
        {
            element.Click();
        }


        public static void selectdropdown( IWebElement element, string value)
        {
                new SelectElement(element).SelectByText(value);
        }

    }
}

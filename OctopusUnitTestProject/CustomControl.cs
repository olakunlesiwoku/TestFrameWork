using ConsoleApplicarion1;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicarion1
{
    public class CustomControl
    {
        public CustomControl()
        {

        }
        //public static IWebElement WaitForBrowserLoading(By elementLocator)
        //    {
        //        try
        //        {
        //            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
        //            return wait.Until(ExpectedConditions.ElementExists(elementLocator));
        //        }
        //        catch (NoSuchElementException)
        //        {
        //            Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
        //            throw;
        //        }
        //    }
    }
}

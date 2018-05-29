﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicarion1
{
    class GetMethods
    {

        public static string GetText(IWebElement element)
        {     
               return element.GetAttribute("value");       

        }



        public static string GetTextDDL(IWebElement element)
        {
         
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

           

        }
    }
}

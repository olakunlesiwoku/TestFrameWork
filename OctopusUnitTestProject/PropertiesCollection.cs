using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicarion1
{
    enum PropertyType{ 
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
   

    class PropertiesCollection
    {
        /*Auto-Implemented property - saves having to pass IWebDriver instance as 
        a parameter when instantiating a new page object or invoking custom controls.
        This property only needs to be instantiated once in the initialisation method of Program.cs    [Ola 29/5/2018]**/

        public static IWebDriver driver { get; set; }
    }
}

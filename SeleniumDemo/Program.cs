using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //navigacija na stranicu

            driver.Navigate().GoToUrl("http://google.com");
            IWebElement element = driver.FindElement(By.Name("q"));

            //Insert 
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Manage().Window.Minimize();
            Thread.Sleep(3000);
            driver.Manage().Window.FullScreen();
            Thread.Sleep(3000);
            element.SendKeys("executeautomation");
            Thread.Sleep(3000);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("oldChrome.png");
            driver.Quit();


        }

    }
}

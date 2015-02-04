using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using Login.Entities;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://accounts.google.com/ServiceLogin?service=mail&continue=https://mail.google.com/mail/&hl=hu");

            LoginPage loginPage = new LoginPage(driver);

            loginPage.login("11111", "111111");

            Console.ReadLine();
        }
    }
}

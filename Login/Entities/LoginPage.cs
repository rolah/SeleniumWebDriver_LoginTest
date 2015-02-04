using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Login.Entities
{
    class LoginPage
    {
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement emailFailed;

        [FindsBy(How = How.Id, Using = "Passwd")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "signIn")]
        private IWebElement loginButton;

        public LoginPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);                
        }

        public void login(string email, string password)
        {
            emailFailed.SendKeys(email);
            passwordField.SendKeys(password);
            loginButton.Click();
        }
    }
}

using DataDrivenWithParameter.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenWithParameter.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement EnterUsername => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EnterEmail => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement EnterPassword => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[2]/li[2]/a"));
        public void ClickOnSignUp()
        {
            SignUp.Click();
        }
        public void IEnterUsername(string username) 
        { 
            EnterUsername.SendKeys(username);
        }
        
        public void IEnterEmail(string email)
        {
            EnterEmail.SendKeys(email);
        } 
        public void IEnterPassword(string password) 
        { 
            EnterPassword.SendKeys(password);
        }

        public void ClickOnSignUpButton() 
        { 
           SignUpButton.Click();
        }

        public void NavigateToWebsite(string gotourl)
        {
           driver.Navigate().GoToUrl(gotourl);
        }

        public bool IsNewArticleDisplayed() 
        {
            return NewArticle.Displayed;
        
        }













    }
}

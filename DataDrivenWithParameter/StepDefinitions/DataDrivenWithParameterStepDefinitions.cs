using DataDrivenWithParameter.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithParameter.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterStepDefinitions()
        {
            dataDrivenWithParameterPage= new DataDrivenWithParameterPage();
        }


        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string gotourl)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(gotourl);
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithParameterPage.ClickOnSignUp();
        }

        [Given(@"I enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameterPage.IEnterUsername(username);
        }

        [Given(@"I enter my Email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            dataDrivenWithParameterPage.IEnterEmail(email);
        }

        [Given(@"I enter my Password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameterPage.IEnterPassword(password);
        }

        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithParameterPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithParameterPage.IsNewArticleDisplayed);
        }
    }
}

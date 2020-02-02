using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using SprcFlow_NUnits.POM;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SprcFlow_NUnits.Steps
{
    [Binding]
    public class ChatFeatureSteps
    {
        [Given(@"Chat page is opened")]
        public void GivenChatPageIsOpened()
        {
            

            //IWebDriver driver = (IWebDriver)FeatureContext.Current["driver"];
            //driver.Navigate().GoToUrl("http://e-chat-com.eu-4.evennode.com/");
            AuthorizePage authorizePage = new AuthorizePage((IWebDriver)FeatureContext.Current["driver"]);
            FeatureContext.Current["authorizePage"] = authorizePage;
            Assert.AreEqual("1", "1");
        }
        
        [Given(@"User authorized")]
        public void GivenUserAuthorized(Table table)
        {
            AuthorizePage authorizePage = (AuthorizePage)FeatureContext.Current["authorizePage"];
            authorizePage.Authorise(table.Rows[0]["Login"], table.Rows[0]["Passworld"]);
        }
        
        [When(@"I send message (.*) in text field")]
        public void WhenISendMessageHelloWorldInTextField(string message)
        {
            ChatPage chatPage = new ChatPage((IWebDriver)FeatureContext.Current["driver"]);
            chatPage.SendMessage(message);
            Thread.Sleep(2000);

        }
        
        [When(@"I click Send message button")]
        public void WhenIClickSendMessageButton()
        {
            new ChatPage((IWebDriver)FeatureContext.Current["driver"]).ClickSendMessageButton();
            Thread.Sleep(2000);

        }
        
        [Then(@"Message with text (.*) is displayed from authorized user")]
        public void ThenMessageWithTextHelloWorldIsDisplayedFromAuthorizedUser(string expected)
        {
            string actualMessage = new ChatPage((IWebDriver)FeatureContext.Current["driver"]).GetLastMessageText();
            Thread.Sleep(2000);

            Assert.AreEqual(expected, actualMessage);

        }

        [Then(@"fg dfg dfs sdfgh")]
        public void ThenFgDfgDfsSdfgh()
        {
            ScenarioContext.Current.Pending();
        }

    }
}

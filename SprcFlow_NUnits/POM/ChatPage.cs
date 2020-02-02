using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprcFlow_NUnits.POM
{
    class ChatPage
    {
        IWebDriver driver;
        public By TextField;
        public By SendMessageButton;
        public By PersonalMessage;
        


        public ChatPage(IWebDriver driver)
        {
            this.driver = driver;
            TextField = By.Id("messageText");
            SendMessageButton = By.ClassName("message-inp__send");
            PersonalMessage = By.XPath("//div[@class = 'body-messageUser']");

        }


        public void SendMessage(string message)
        {
            driver.FindElement(TextField).SendKeys(message);
            
        }

        public void ClickSendMessageButton()
        {
            driver.FindElement(SendMessageButton).Click();
        }
        public string GetLastMessageText()
        {
           //List<IWebElement> Messages = driver.FindElements(PersonalMessage).ToList();
            var AllPersonalMessagesTexts = driver.FindElements(PersonalMessage);
            var LastMessage = AllPersonalMessagesTexts[AllPersonalMessagesTexts.Count - 1];
            return LastMessage.Text;
        }

    }
}

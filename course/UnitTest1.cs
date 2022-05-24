using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using mrsLibrary;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace course
{
    class Base : Library
    {
        [SetUp]
        public void intiliaze()
        {
            chrome(" https://courses.letskodeit.com/practice");
           
        }
        [Test]
        public void checkbox()
        {
            Findxpath("//input[@id='bmwcheck']").Click();
            time(2000);
            Findxpath("//input[@id='benzcheck']").Click();
            time(2000);
            Findxpath("//input[@id='hondacheck']").Click();
            time(2000);
            
        }
        [Test]
        public void mouse_however()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            js.ExecuteScript("window.scrollBy(0,500)");
            IWebElement top = Findxpath("//button[@id='mousehover']");
            top.Click();
            time(2000);
            Actions act = new Actions(Driver);

            act.MoveToElement(Findxpath("//button[@id='mousehover']"))
                .KeyDown(Keys.Down)
                .Click()
            .Perform();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Findxpath("//button[@id='mousehover']")
               .Click();
            time(2000);
            Actions action = new Actions(Driver);
            action.MoveToElement(Findxpath("//button[@id='mousehover']"))

                .KeyDown(Keys.Down)
                .KeyDown(Keys.Down)
                .Click()
                .Perform();
        }
        [Test]
        public void Radio_Button()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//input[@id='bmwradio']").Click();
            time(2000);
            Findxpath("//input[@id='benzradio']").Click();
            time(2000);
            Findxpath("//input[@id='hondaradio']").Click();
            time(2000);
        }
        public void select_class()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//select[@id='carselect']").Click();
            time(2000);
            Actions actio = new Actions(Driver);
            actio.MoveToElement(Findxpath("//select[@id='carselect']"))
                .KeyDown(Keys.Down)
            .KeyDown(Keys.Down)
            .Click()
                .Perform();
            time(2000);
        }
        [Test]
        public void SwitchAlert()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//input[@id='name']").SendKeys("Rachit");
            time(2000);
            Findxpath("//input[@id='alertbtn']").Click();
            time(2000);
            Driver.SwitchTo().Alert().Accept();
            Findxpath("//input[@id='confirmbtn']").Click();
            time(2000);
            Driver.SwitchTo().Alert().Accept();
            time(2000);

        }
        [Test]
        public void Switch_Tab()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//a[@id='opentab']").Click();
            time(2000);
            string p = Driver.WindowHandles[1];
            string g = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(p);
            time(2000);
            Driver.Close();

            time(2000);
            Driver.SwitchTo().Window(g);
            time(5000);
        }
        [Test]
        public void Window()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//button[@id='openwindow']").Click();
            time(2000);
            string h = Driver.WindowHandles[1];
            string k = Driver.WindowHandles[0];
            Driver.SwitchTo().Window(h);
            Driver.Manage().Window.Maximize();
            time(2000);
            Driver.Close();
            Driver.SwitchTo().Window(k);
            time(2000);
        }
       
        [TearDown]
        public void endtest()
        {
            quit();

        }
    }

   
}

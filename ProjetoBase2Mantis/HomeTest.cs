using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase2Mantis
{
    class HomeTest
    {
        private ChromeDriver chrome;
        private HomePage home;

        [SetUp]
        public void AntesDosTestes()
        {
            chrome = new ChromeDriver();
            home = new HomePage(chrome);
        }

        [Test]
        public void DeveLogar()
        {
            home.visita();
            IWebElement campoNomeUsuario = chrome.FindElement(By.Id("username"));
            campoNomeUsuario.SendKeys("administrator");
            chrome.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement btnEntrar = chrome.FindElement(By.XPath("//*[@id='login-form']"));
            btnEntrar.Submit();
           



        }

    }
}

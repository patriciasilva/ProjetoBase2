using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase2Mantis
{
    class LoginTest
    {
        private ChromeDriver chrome;
        private LoginPage home;

        [SetUp]
        public void AntesDosTestes()
        {
            chrome = new ChromeDriver();
            home = new LoginPage(chrome);
        }

        [Test]
        public void Cenario1DeveLogar()
        {

            home.visita();
            home.login("administrator", "213821"); 
        }

        [Test]
        public void Cenario2UsernameIncorreto()
        {
            home.visita();
            home.login("teste", "213821");

        }

        [TearDown]
        public void Sair()
        {
            chrome.Close();
        }
    }
}
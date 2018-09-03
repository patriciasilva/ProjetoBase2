using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase2Mantis
{
    class LoginPage : BasePage
    {
 
        private IWebDriver driver;

        IWebElement Username => driver.FindElement(By.Id("username"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement BtnEntrar => driver.FindElement(By.XPath("//*[@id='login-form']"));


        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;

        }

        public void visita()
        {
            driver.Navigate().GoToUrl("http://mantis.patricia.base2.com.br/login_page.php");

        }

        public void login(string username, string password)
        {
            Username.SendKeys(username);
            BtnEntrar.Submit();
            Password.SendKeys(password);
            BtnEntrar.Submit();

        }

    }
}

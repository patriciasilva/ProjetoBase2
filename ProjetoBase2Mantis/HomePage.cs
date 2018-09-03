using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase2Mantis
{
    class HomePage
    {

        private IWebDriver driver;
        
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void visita()
        {
            driver.Navigate().GoToUrl("http://mantis.patricia.base2.com.br/login_page.php");

        }

    }
}

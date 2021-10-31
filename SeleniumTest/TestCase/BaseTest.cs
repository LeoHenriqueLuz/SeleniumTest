using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Handler;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.TestCase
{
    // Classe base para todos os testes
  public abstract class BaseTest
    {
        // Selenium WebDriver
        protected IWebDriver Driver;

        // Url da aplicação que será testado
        protected string Url = ConfigurationManager.AppSettings["Url"];

        [SetUp] // Anotação NUnit para executar um método antes de cada Teste.
        public void BeforeBaseTest() // Método irá iniciar o navegador na URL definida.
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
        }
        [TearDown] // Anotação NUnit para executar um método depois de cada teste.
        public void AfterBaseTest() // Método para encerrar o teste.
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
                ScreenShotHandler.TakeScreenShot(Driver);

            if (Driver != null)
                Driver.Quit();
        }
    }
}

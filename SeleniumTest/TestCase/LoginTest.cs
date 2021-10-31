using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.TestCase
{
    // Classe que contém os casos de teste para Login

    [TestFixture] // Anotação do NUnit para marcar a classe que contém casos de teste.
    public class LoginTest : BaseTest
    {

        [Test] // Anotação NUnit que diz que o método a seguir será uma caso de teste automatizado.
               // Método para implementar um caso de teste de login e o esperado é que usuário se logue corretamente.
        public void SucessFulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LoginAs("admin", "admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

    }
}

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
    // Classe que contém casos de teste para Formulário

    [TestFixture]
    class EmployeeTest : BaseTest
    {
        // Page Object para formulário de cadastro
        private EmployeePage EmployeePage;

        [SetUp]
        // Método para logar-se na aplicação
        public void BeforeTest() 
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage = loginPage.LoginAs("admin", "admin123");
        }

        [TestCase("Leonardo", "Leo@gmail.com", "São Paulo", "11 999999999")] // Anotação do NUnit que marca um método de caso de teste com parametros.
        [TestCase("Marcelo", "Marcelo@gmail.com", "São Paulo", "11 98888899")]

        // Método que implementa um caso de teste p/ adicionar cadastro - resultado esperado é que adicione corretamente um cadastro.
        public void AddEmployeeTest(string name, string email, string address, string phone) 
        {
            EmployeePage.AddEmployee(name, email, address, phone);
            Assert.IsTrue(EmployeePage.IsSucessAlertPresent());
        }

    }
}

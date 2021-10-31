using OpenQA.Selenium;
using SeleniumTest.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.PageObject
{
    // Classe representa a pagina de formulário
    public class EmployeePage : BasePage
    {
        //Localizadores
        protected By form = By.Id("formEmployee");
        protected By NameInput = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        protected By EmailInput = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        protected By AddressTextArea = By.Id("address");
        protected By PhoneInput = By.Id("phone");
        protected By AddButton = By.Id("addButton");

        // Construtor - lança uma excessão caso titulo da pagina de formulário não seja correto.
        public EmployeePage( IWebDriver driver) 
        {
            Driver = driver;
            if (!Driver.Title.Equals("AUT Form – TestFaceClub"))
                throw new Exception("This is not the Page Employee");
        } 

        // Método para adicionar um cadastro.
        public void AddEmployee(string name, string email, string address, string phone) 
        {
            Driver.FindElement(NameInput).SendKeys(name);
            Driver.FindElement(EmailInput).SendKeys(email);
            Driver.FindElement(AddressTextArea).SendKeys(address);
            Driver.FindElement(PhoneInput).SendKeys(phone);
            Driver.FindElement(AddButton).Click();
        }

        // Método para verificar se Formulário de cadastro está preenchido.
        // Retorna True se sim e False caso contrário.
        public bool FormIsPresent() 
        {
            return WaitHandler.ElementIsPresent(Driver, form);
        }

        // Método para capturar um "Aceitar" do alerta disparado.
        // retorna true se detectar um alerta aceito, caso contrário false.
         public bool IsSucessAlertPresent() 
        {
            try 
            {
                Driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException) { }
            return false;
        }

    }
}

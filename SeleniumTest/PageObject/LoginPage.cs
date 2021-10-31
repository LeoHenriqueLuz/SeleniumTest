using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.PageObject
{
    // Classe representa a página de Login 
   public  class LoginPage : BasePage
    {
      
        // Localizadores
        protected By UserInput = By.Id("user");
        protected By PasswordInput = By.Id("pass");
        protected By LoginButton = By.Id("loginButton");

        // Construtor - Lança uma excessão caso titulo da pagina de login não seja a correta.
        public LoginPage(IWebDriver driver) 
        {
            Driver = driver;

            if (!Driver.Title.Equals("AUT Login – TestFaceClub"))
                throw new Exception("This is not the page Login");

        }

        // Método para escrever um usúario
        public void TypeUserName(string user) 
        {
            Driver.FindElement(UserInput).SendKeys("user");
        }

        // Método para escrever uma senha
        public void TypePassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys("password");
        }

        // Método para fazer um click no botão de login
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }

        // Método para se logar e o retorno esperado é pagina com Formulário de cadastro.
        public EmployeePage LoginAs(string user, string password) 
        {
            TypeUserName(user);
            TypePassword(password);
            ClickLoginButton();
            return new EmployeePage(Driver);
        
        }

    }
}

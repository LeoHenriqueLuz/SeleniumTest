using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Handler
{
    // Classe para manipular as esperas explícitas 
   public class WaitHandler
    {
        // Método para esperar um elemento presente na pagina web
       public static bool ElementIsPresent(IWebDriver driver, By locator ) 
        {
            try 
            {
                // Retorna True  se encontrar o elemento, caso contrario retorna false.
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch { }
            return false;
        }
    }
}

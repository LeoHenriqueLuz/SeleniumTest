using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Handler
{
    // Classe para manipular as capturas de tela dos testes
   public class ScreenShotHandler
    {
        //Obter o endereço do diretório onde a imagem será salva
        private static string DirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        // Método para realizar a captura de tela com Selenium
        // Retorna o diretório de onde a imagem foi capturada
        public static string TakeScreenShot(IWebDriver driver) 
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            string imagePath = DirectoryPath + "//img_" + milliseconds + ".png";
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(imagePath, ScreenshotImageFormat.Png);
            return imagePath;
        }
    }
}

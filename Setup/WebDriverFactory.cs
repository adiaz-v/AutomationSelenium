using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPrueba.Setup
{
    public class WebDriverFactory
    {

        string driverLocation = Directory.GetCurrentDirectory() + @"\Drivers\";
        public IWebDriver Create()
        {
            return GetChromeDriver();
        }

        //IWebDrvier es una interfaz que busca en el escritorio por defecto de, las ref erencias del proyecto, el ChromeDriver.exe
        //Este metodo busca la localizaicon del Chrome driver y devuelve un objeto ChromeDriver() con parametro de localizacion
        private IWebDriver GetChromeDriver()
        {
            //var directorio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", @"D:\Test");
            return new ChromeDriver(driverLocation, options);
        }
    }
}

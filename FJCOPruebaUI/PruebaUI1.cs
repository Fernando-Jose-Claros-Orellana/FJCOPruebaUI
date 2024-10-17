using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FJCOPruebaUI
{
	[TestClass]
    public class PruebaUI1 : IDisposable
    {
        private IWebDriver driver;

        public PruebaUI1()
        {
            // Inicializa el controlador de Chrome
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void Blazor()
        {
            // Navega a Google
            driver.Navigate().GoToUrl("https://localhost:7293/product-list");

            // Espera un momento para que se carguen los resultados
            System.Threading.Thread.Sleep(1000);

            // Encuentra el cuadro de búsqueda
            var btn = driver.FindElement(By.Name("crear"));

            btn.Click();

            // Espera un momento para que se carguen los resultados
            System.Threading.Thread.Sleep(1000);

            var nombre = driver.FindElement(By.Id("Nombre"));

            nombre.SendKeys("PruebaN");

            var descripcion = driver.FindElement(By.Id("Descripcion"));

            descripcion.SendKeys("PruebaD");

            var precio = driver.FindElement(By.Id("Precio"));

            precio.SendKeys("100");

            var guardar = driver.FindElement(By.Name("guardar"));

            guardar.Click();

            // Espera un momento para que se carguen los resultados
            System.Threading.Thread.Sleep(1000);

            var regresar = driver.FindElement(By.Name("regresar"));

            regresar.Click();

            // Espera un momento para que se carguen los resultados
            System.Threading.Thread.Sleep(1000);

        }

        public void Dispose()
        {
            // Cierra el navegador
            driver.Quit();
        }
    }
}

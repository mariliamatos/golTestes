using System;
using System.Collections.Generic;
using System.Text;


using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System.Threading;

namespace GolVoo.Test
{
    class HomePage
    {
        public static IWebDriver driver;
        private static string baseURL;

        public HomePage() {

            driver = new WebDriver().GetWebDriver();
        }


        public void IrParaHomePage()
        {

            driver.Manage().Window.Maximize();
            baseURL = "https://www.voegol.com.br/pt";
            driver.Navigate().GoToUrl(baseURL);

        }

        public void InformarLugarDePartida(string lugarPartida)
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Use seta para baixo para exibir as opções de aeroporto ou completar o nome do aeroporto digitado.'])[1]/following::div[1]")).Click();
            driver.FindElement(By.Id("header-chosen-origin")).Clear();
            driver.FindElement(By.Id("header-chosen-origin")).SendKeys(lugarPartida);
            driver.FindElement(By.XPath("//*[@id='purchase-box']/form[2]/div[1]/div[2]/div[1]/div/ul/li")).Click();
            Thread.Sleep(2000);
        }

        public void InformarDatasDoVoos()
        {
            // Get the current date.
            DateTime thisDay = DateTime.Today.AddDays(3); // adicionei dois dias
            // Display the date in the default (general) format.
            Console.WriteLine(thisDay.Day.ToString());


            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Outubro'])[1]/following::span[1]")).Click();
            driver.FindElement(By.LinkText(thisDay.Day.ToString())).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Outubro'])[1]/following::div[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sáb'])[2]/following::a[" + thisDay.Day.ToString() + "]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Outubro'])[1]/following::div[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sáb'])[2]/following::a[" + thisDay.Day.ToString() + "]")).Click();


            Thread.Sleep(2000);

        }

        public void EscolherPassagens()
        {

            Thread.Sleep(4000);
            driver.FindElement(By.Id("ida")).FindElements(By.ClassName("lessPrice"))[0].Click();
            driver.FindElement(By.Id("volta")).FindElements(By.ClassName("lessPrice"))[0].Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Name("ControlGroupSelect2View$AvailabilityInputSelect2View$ButtonSubmit")).Click();
        }

        public void ClicarNoBotaoComprar()
        {
            driver.FindElement(By.XPath("//*[@id='btn-box-buy']")).Click();
        }

        internal void InformarQuantidadeAdultos()
        {
            driver.FindElement(By.XPath("//*[@id='number-adults']")).Click();
            driver.FindElement(By.XPath("//*[@id='number-adults']")).SendKeys(Keys.Backspace);
            driver.FindElement(By.XPath("//*[@id='number-adults']")).SendKeys("2");
        }

        internal void InformarDestino(string destino)
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Use seta para baixo para exibir as opções de aeroporto ou completar o nome do aeroporto digitado.'])[2]/following::div[1]")).Click();
            driver.FindElement(By.Id("header-chosen-destiny")).Clear();
            driver.FindElement(By.Id("header-chosen-destiny")).SendKeys(destino);
            driver.FindElement(By.XPath("//*[@id='purchase-box']/form[2]/div[1]/div[3]/div[1]/div[1]/div/ul/li")).Click();
            Thread.Sleep(1000);
        }
    }
}

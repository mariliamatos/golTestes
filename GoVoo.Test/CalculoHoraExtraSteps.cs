using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System.Threading;

namespace GooVoo.Test
{
    [Binding]
    public class StepDefinitions
    {

        public static IWebDriver driver;
        private static string baseURL;

        [Given(@"que estou na home page")]
        public void DadoQueEstouNaHomePage()
        {
            driver = new ChromeDriver("C:\\Drivers");
            driver.Manage().Window.Maximize();
            baseURL = "https://www.voegol.com.br/pt";
            driver.Navigate().GoToUrl(baseURL);

        }

        [Given(@"que informo meu lugar de partida como '(.*)'")]
        public void DadoQueInformoMeuLugarDePartidaComo(string sDU0)
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Use seta para baixo para exibir as opções de aeroporto ou completar o nome do aeroporto digitado.'])[1]/following::div[1]")).Click();
            driver.FindElement(By.Id("header-chosen-origin")).Clear();
            driver.FindElement(By.Id("header-chosen-origin")).SendKeys("sdu");
            driver.FindElement(By.XPath("//*[@id='purchase-box']/form[2]/div[1]/div[2]/div[1]/div/ul/li")).Click();

        }

        [Given(@"que eu informo meu destino como '(.*)'")]
        public void DadoQueEuInformoMeuDestinoComo(string gru0)
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Use seta para baixo para exibir as opções de aeroporto ou completar o nome do aeroporto digitado.'])[2]/following::div[1]")).Click();
            driver.FindElement(By.Id("header-chosen-destiny")).Clear();
            driver.FindElement(By.Id("header-chosen-destiny")).SendKeys("gru");
            driver.FindElement(By.XPath("//*[@id='purchase-box']/form[2]/div[1]/div[3]/div[1]/div[1]/div/ul/li")).Click();


        }

        [Given(@"que eu informo a data de partida e volta")]
        public void DadoQueEuInformoADataDePartidaEVolta()
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

        [Given(@"que infomo a quantidade de adultos")]
        public void DadoQueInfomoAQuantidadeDeAdultos()
        {
            driver.FindElement(By.XPath("//*[@id='number-adults']")).Click();
            driver.FindElement(By.XPath("//*[@id='number-adults']")).SendKeys(Keys.Backspace);
            driver.FindElement(By.XPath("//*[@id='number-adults']")).SendKeys("2");

        }

        [Given(@"que clico no botão comprar")]
        public void DadoQueClicoNoBotaoComprar()
        {
            driver.FindElement(By.XPath("//*[@id='btn-box-buy']")).Click();
        }

        [Given(@"que escolho as passagens com menor preço")]
        public void DadoQueEscolhoAsPassagensComMenorPreco()
        {
            Thread.Sleep(4000);
            driver.FindElement(By.Id("ida")).FindElements(By.ClassName("lessPrice"))[0].Click();
            driver.FindElement(By.Id("volta")).FindElements(By.ClassName("lessPrice"))[0].Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Name("ControlGroupSelect2View$AvailabilityInputSelect2View$ButtonSubmit")).Click();

        }

    }
}
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
using GolVoo.Test;

namespace GooVoo.Test
{
    [Binding]
    public class StepDefinitions
    {

        HomePage homePage = new HomePage();

        [Given(@"que estou na home page")]
        public void DadoQueEstouNaHomePage()
        {

            homePage.IrParaHomePage();

        }

        [Given(@"que informo meu lugar de partida como '(.*)'")]
        public void DadoQueInformoMeuLugarDePartidaComo(string lugarPartida)
        {
            homePage.InformarLugarDePartida(lugarPartida);
        }

        [Given(@"que eu informo meu destino como '(.*)'")]
        public void DadoQueEuInformoMeuDestinoComo(string destino)
        {

            homePage.InformarDestino(destino);
           

        }

        [Given(@"que eu informo a data de partida e volta")]
        public void DadoQueEuInformoADataDePartidaEVolta()
        {
            homePage.InformarDatasDoVoos();
        }

        [Given(@"que infomo a quantidade de adultos")]
        public void DadoQueInfomoAQuantidadeDeAdultos()
        {
            homePage.InformarQuantidadeAdultos();
        }

        [Given(@"que clico no botão comprar")]
        public void DadoQueClicoNoBotaoComprar()
        {
            homePage.ClicarNoBotaoComprar();
        }

        [Then(@"que escolho as passagens com menor preço")]
        public void EntaoQueEscolhoAsPassagensComMenorPreco()
        {
            homePage.EscolherPassagens();

        }


    }
}
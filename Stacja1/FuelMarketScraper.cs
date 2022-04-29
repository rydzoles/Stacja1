using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacja1
{
    public class FuelMarketScraper
    {
        private const string BaseUrl = "https://www.lotos.pl/144/dla_biznesu/hurtowe_ceny_paliw";
     

    
        public  HtmlDocument GetFuelANdPrice()
        {
            var web = new HtmlWeb();
            var document = web.Load(BaseUrl);
            return document;
        }

      
    }
   
}

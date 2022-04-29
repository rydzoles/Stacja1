using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacja1
{
    public class ListOfProductAndPrices
    {
        Fuel fuel { get; set; }
        List<Fuel> fuelLine { get; set; }
        FuelMarketScraper ggg = new FuelMarketScraper();
       
        public List<Fuel> NameAndPrice() // tutaj przydaloby sie zebym wstrzyknał delegata
        {
          var name=  ggg.GetFuelANdPrice();
            var tableRows = name.QuerySelectorAll("table tr").Skip(1);
            var counter = 0;
            fuel = new Fuel();
            fuelLine = new List<Fuel>();

            foreach (var tableRow in tableRows)
            {
                counter++;
                var tds = tableRow.QuerySelectorAll("td");
                fuel.Name = tds[0].InnerText;
                fuel.Price = double.Parse(tds[1].InnerText);

                var fuelAndPrice = new Fuel
                {
                    Name = fuel.Name,
                    Price = fuel.Price
                };
                fuelLine.Add(fuelAndPrice);
                if (counter == 3)
                    break;
            }
            return fuelLine;
        }
    }
}

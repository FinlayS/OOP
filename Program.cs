using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesmen = new List<Salesman>()
            {
                new CarSalesman("Steve", "Rogers"),
                new CarSalesman("bob", "boss"),
                new RetailSalesPerson("Erik", "Erikson"),
                new InsuranceBroker("me", "ooo"),
                new OnlineMarketer("Mark", "Onl")
            };

            foreach (var item in salesmen)
            {
                ShowMeHowToSell(item);
            }

            List<SelfDeveloping> selfDeveloping = new List<SelfDeveloping>()
            {
                new RetailSalesPerson("Erik", "Erikson"),
                new WebDeveloper("TS")
            };

            foreach (var item in selfDeveloping)
            {
                ShowMeHowToSelfDevelop(item);
            }
        }

        static void ShowMeHowToSell(Salesman salesman)
        {
            salesman.Sell();
        }

        static void ShowMeHowToSelfDevelop(SelfDeveloping selfDeveloping)
        {
            selfDeveloping.Develop();
        }

    }
}

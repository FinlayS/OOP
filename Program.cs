using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarSalesman steveTheSalesman = new CarSalesman("Steve", "Rogers");
            // Console.WriteLine(steveTheSalesman.FullName);
            // steveTheSalesman.Sell();

            // RetailSalesPerson erikTheCarSalesDude = new RetailSalesPerson("Erik", "Erikson");
            // Console.WriteLine(erikTheCarSalesDude.FullName);
            // erikTheCarSalesDude.Sell();
            // erikTheCarSalesDude.Develop();

            WebDeveloper mike = new WebDeveloper("JS");
            mike.Code();
            mike.Develop();

            SoftwareDeveloper bob = new SoftwareDeveloper("RPG");
            bob.Code();
        }
    }
}

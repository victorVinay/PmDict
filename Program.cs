using System;
using System.Collections.Generic;
using System.Linq;

namespace PmDict
{
    class Program
    {
        Dictionary<int, string> PrimeMinister = new Dictionary<int, string>()
            {
                {1998,"Atal Bihari Vajpayee"},
                {2014,"Narendra Modi"},
                {2004,"Manmohan Singh"}

            };
        static void Main(string[] args)
        {


            var pm = new Program();
            pm.FindPm(2004);
            pm.AddPm(2019, "Narendra Modi");
            pm.SortUsingYear();

        }

        private void SortUsingYear()
        {
            foreach (KeyValuePair<int, string> pm in PrimeMinister.OrderBy(key => key.Key))
            {
                Console.WriteLine("{0},{1}", pm.Key, pm.Value);
            }
        }

        private void AddPm(int year, string name)
        {
            PrimeMinister.Add(year, name);
        }

        private void FindPm(int year)
        {
            var p = PrimeMinister[year];
        }
    }
}

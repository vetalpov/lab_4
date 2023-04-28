using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._2
{
    internal class Tariff
    {
        public string Name { get; set; }
        public double MonthlyFee { get; set; } 
        public int Traffic { get; set; }
        public int ClientsCount { get; set; }

        public Tariff(string name, double monthlyFee, int traffic, int clientsCount)
        {
            Name = name;
            MonthlyFee = monthlyFee;
            Traffic = traffic;
            ClientsCount = clientsCount;
        }

        public override string ToString()
        {
            return string.Format("{0}\t\t{1}\t\t{2}\t\t{3}", Name, MonthlyFee, Traffic, ClientsCount);
        }
    }
}

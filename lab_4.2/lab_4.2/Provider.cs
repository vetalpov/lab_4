using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4._2
{
    internal class Provider
    {
        private List<Tariff> _tariffs = new List<Tariff>(); 
                                                           
        public void AddTariff(Tariff tariff)
        {
            _tariffs.Add(tariff);
        }

        
        public void RemoveTariff(Tariff tariff)
        {
            _tariffs.Remove(tariff);
        }

        
        public Dictionary<string, int> GetClientsCountByTariff()
        {
            Dictionary<string, int> clientsCountByTariff = new Dictionary<string, int>();
            foreach (Tariff tariff in _tariffs)
            {
                if (clientsCountByTariff.ContainsKey(tariff.Name))
                {
                    clientsCountByTariff[tariff.Name] += tariff.ClientsCount;
                }
                else
                {
                    clientsCountByTariff.Add(tariff.Name, tariff.ClientsCount);
                }
            }
            return clientsCountByTariff;
        }

       
        public List<Tariff> SortTariffsByTraffic()
        {
            return _tariffs.OrderByDescending(tariff => tariff.Traffic).ToList();
        }

       
        public Tariff FindTariff(int minTraffic, int maxTraffic, double maxMonthlyFee)
        {
            return _tariffs.FirstOrDefault(
                tariff => tariff.Traffic >= minTraffic && tariff.Traffic <= maxTraffic && tariff.MonthlyFee <= maxMonthlyFee);
        }
    }
}

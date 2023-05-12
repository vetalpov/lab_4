using lab_4._2;

public class Program
{
    public static void Main()
    {
        Provider provider = new Provider();
        
        provider.AddTariff(new Tariff("Тариф 1", 100, 10, 50));
        provider.AddTariff(new Tariff("Тариф 2", 200, 20, 100));
        provider.AddTariff(new Tariff("Тариф 3", 300, 30, 150));
        provider.AddTariff(new Tariff("Тариф 4", 400, 40, 200));
        provider.AddTariff(new Tariff("Тариф 5", 500, 50, 250));

        
        Console.WriteLine("Список тарифiв:");
        Console.WriteLine("Назва\tАбонентська плата\tОбсяг трафiку\tКiлькiсть клiєнтiв");
        foreach (Tariff tariff in provider.SortTariffsByTraffic())
        {
            Console.WriteLine(tariff);
        }
        Console.WriteLine();

        
        Console.WriteLine("Кiлькiсть клiєнтiв по кожному тарифу:");
        Dictionary<string, int> clientsCountByTariff = provider.GetClientsCountByTariff();
        foreach (KeyValuePair<string, int> kvp in clientsCountByTariff)
        {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
        Console.WriteLine();

        Console.WriteLine("Пошук тарифу за обсягом трафiку та вартiстю абонентської плати:");
        Tariff foundTariff = provider.FindTariff(15, 35, 250);
        if (foundTariff != null)
        {
            Console.WriteLine("Знайдено тариф: {0}", foundTariff.Name);
        }
        else
        {
            Console.WriteLine("Тариф не ");
        }

        Console.ReadLine();
    }
}

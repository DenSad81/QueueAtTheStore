using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> purchases = new Queue<int>();
        Random random = new Random();
        int quantityOfPurchases = 10;
        int minPrice = 10;
        int maxPrice = 100;
        int moneyInBankAccount = 0;

        for (int i = 0; i < quantityOfPurchases; i++)
            purchases.Enqueue(random.Next(minPrice, maxPrice));

        while (purchases.Count > 0)
        {
            foreach (var item in purchases)
                Console.WriteLine(item);

            Console.WriteLine();
            int purchasePrice = purchases.Dequeue();
            Console.WriteLine("Цена за покупку: " + purchasePrice);
            moneyInBankAccount += purchasePrice;
            Console.WriteLine("Количество денег на счету: " + moneyInBankAccount);
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("Покупки закончились количество денег на счету: " + moneyInBankAccount);
    }
}
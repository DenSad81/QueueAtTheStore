using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> purchases = new Queue<int>();
        int quantityOfPurchases = 10;
        int minPrice = 10;
        int maxPrice = 100;
        int moneyInBankAccount = 0;

        purchases = FillQueue(quantityOfPurchases, minPrice, maxPrice);

        while (purchases.Count > 0)
        {
            ShowQuenque(purchases);

            Console.WriteLine();
            int purchasePrice = purchases.Dequeue();
            Console.WriteLine("Цена за покупку: " + purchasePrice);
            Console.WriteLine("Количество денег на счету: " + moneyInBankAccount);
            Console.ReadKey();
            moneyInBankAccount += purchasePrice;
            Console.Clear();
        }

        Console.WriteLine("Покупки закончились количество денег на счету: " + moneyInBankAccount);
    }

    static Queue<int> FillQueue(int volume, int minValue, int maxValue)
    {
        Queue<int> tempQueue = new Queue<int>();
        Random random = new Random();

        for (int i = 0; i < volume; i++)
            tempQueue.Enqueue(random.Next(minValue, maxValue));

        return tempQueue;
    }

    static void ShowQuenque(Queue<int> tempQueue)
    {
        foreach (var item in tempQueue)
            Console.WriteLine(item);
    }

}
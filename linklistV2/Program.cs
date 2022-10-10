using System;

namespace linklist;

class Program
{

    static void Main(string[] args)
    {

        LinkList<int> oddAndEven = new LinkList<int>(0);


        var threadOdd = new Thread(delegate () { AddOdd(oddAndEven); });
        var threadEven = new Thread(delegate () { AddEven(oddAndEven); });
        threadOdd.Start();
        threadEven.Start();


        Console.WriteLine("_______________");



        oddAndEven.Print();

    }

    public static void AddOdd(LinkList<int> list)
    {
        for (int i = 1; i < 100; i = i + 2)
        {
            Thread.Sleep(0);
            list.Add(i);
        }


    }

    public static void AddEven(LinkList<int> list)
    {
        for (int i = 2; i < 100; i = i + 2)
        {
            Thread.Sleep(0);
            list.Add(i);
        }
    }

}
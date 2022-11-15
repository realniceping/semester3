using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace laba2
{

    class Program
    {

        public static void Main()
        {

            BenchmarkRunner.Run<BenchmarkTester>();

            // bool bench = true;
            // if (bench)
            // {
            //     var summary = BenchmarkRunner.Run<BenchmarkTester>();
            // }

            // Kucha kucha = new Kucha();
            // Random rng = new Random();

            // for (int i = 0; i < 100; i++)
            // {
            //     kucha.push(new Item(rng.Next(100000), rng.Next(1, 10)));
            // }

            // for (int i = 0; i < 1000; i++)
            // {
            //     try
            //     {
            //         Console.WriteLine(kucha.pop().ToString());
            //     }
            //     catch (Exception e)
            //     {
            //         Console.WriteLine(e.Message);
            //         break;
            //     }
            // }
        }


    }

    [MemoryDiagnoser]
    public class BenchmarkTester
    {
        [Benchmark]
        public void test()
        {
            Kucha kucha = new Kucha();
            Random rng = new Random();

            for (int i = 0; i < 100; i++)
            {
                kucha.push(new Item(rng.Next(100000), rng.Next(1, 10)));
            }

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    var s = kucha.pop();
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e.Message);
                    break;
                }
            }
        }

        [Benchmark]
        public void testPriorityQueue()
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(100);
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                queue.Enqueue(rand.Next(100000), rand.Next(10));
            }
            for (int i = 0; i < 100; i++)
            {
                queue.Peek();
            }

        }
    }


    class Kucha
    {
        public List<Item> storage = new List<Item>();

        public Kucha()
        {
            this.storage = new List<Item>();
        }


        public void push(Item i)
        {
            this.storage.Add(i);
        }


        public Item pop()
        {
            Item tempItem;
            int max = 0;
            foreach (Item i in this.storage)
            {
                if (i.priority > max)
                {
                    max = i.priority;
                }
            }

            foreach (Item i in this.storage)
            {
                if (i.priority == max)
                {
                    tempItem = i;
                    this.storage.Remove(i);
                    return tempItem;
                }
            }

            throw new Exception("storage is empty");
        }

    }

    class Item
    {
        public int value;

        public int priority;

        public Item(int value, int priority)
        {
            this.value = value;
            this.priority = priority;
        }

        public override string ToString()
        {
            return "(" + this.value + ", " + this.priority + ")";
        }
    }

}

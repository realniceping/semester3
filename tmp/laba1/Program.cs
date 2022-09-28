using System;

namespace laba1
{

    class Program
    {

        static void Main(string[] args)
        {

            var root = new Nodee(0);
            var rand = new Random();

            for (int i = 0; i < 1000000; i++)
            {


                insert(rand.Next(20000) - 10000, root);

            }

            System.Console.WriteLine("tree created");

            long find = 0;
            while (find != 10001)
            {

                find = (long)Convert.ToInt64(Console.ReadLine());
                shearch(find, root);
            }


            static void insert(long value, Nodee root)
            {

                if (root.value > value)
                {
                    if (root.left == null)
                    {
                        root.left = new Nodee(value);

                    }
                    else
                    {
                        insert(value, root.left);
                    }

                }
                if (root.value < value)
                {
                    if (root.rigth == null)
                    {
                        root.rigth = new Nodee(value);
                        return;
                    }

                    {
                        insert(value, root.rigth);
                    }
                }



            }


            static void shearch(long value, Nodee root)
            {

                if (root.value == value)
                {
                    System.Console.WriteLine("we found node!");
                    return;
                }


                if (root.value < value)
                {
                    if (root.rigth == null)
                    {
                        System.Console.WriteLine("node with this value not exist");
                    }
                    else
                    {
                        shearch(value, root.rigth);
                    }
                }
                else
                {
                    if (root.left == null)
                    {
                        System.Console.WriteLine("node with this value not exist");
                    }
                    else
                    {
                        shearch(value, root.left);
                    }

                }


            }

        }

    }
}
using System;

namespace linklist;

class Program{

    static void Main(string[] args){
        
        
        Random rng = new Random();
        LinkList a = new LinkList(10);
        Console.WriteLine(10);

        for(int i = 0; i < 10; i++){
            int b = rng.Next(10);
            a.Add(b);
            Console.WriteLine(b);
        }

        Console.WriteLine("_______________");

        a.Print();

    }

    

}
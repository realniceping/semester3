using System;
using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace linklist;

class Bench
{

    [Benchmark]
    public void Test(){

        Random rng = new Random();
        LinkList<int> a = new LinkList<int>(10);
        Console.WriteLine(10);

        for(int i = 0; i < 10; i++){

            a.Add(rng.Next(10));
        }

        a.Print();

    }

}

class Program{

    static void Main(string[] args){
        
        BenchmarkRunner.Run<Bench>();

    }

    

}
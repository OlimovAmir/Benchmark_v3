using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    class Benchmark
    {
        struct Poin
        {
            public float x;
            public float y;
            public float z;
        }

        static void Foo(Poin value)
        {

        }

        static void Bar(in Poin value) 
        {

        }
        static void Main(string[] args)
        {
            Poin poin = new Poin();



            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(poin);
            }

            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(poin);
            }

            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        }
    }
}

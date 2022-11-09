using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateSomeGarbage();

            Console.WriteLine($"Memory Befor Dispose {GC.GetTotalMemory(false):N0}");
            GC.Collect();
            Console.WriteLine($"Memory Befor Dispose {GC.GetTotalMemory(true):N0}");

            Console.ReadLine();
        }
        static void CreateSomeGarbage()
        {
            for (int i = 0; i < 100; i++)
            {
                Version version = new Version();
            }
        }
    }


}

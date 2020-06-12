using System;

using Abstraction;
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Elektronik elektronik;

            elektronik = new pipo();
            elektronik.smartphone();

            Console.WriteLine();
            elektronik = new siomay();
            elektronik.smartphone();

            Console.ReadKey();
        }
    }
}

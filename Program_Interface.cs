using System;

using Abstraction.Interface;
namespace Abstraction

{
    class Program
    {
        static void Main(string[] args)
        {
            IElektronik elektronik;

            elektronik = new pipo();
            elektronik.smartphone();

            Console.WriteLine();
            elektronik = new sioamay();
            elektronik.smartphone();

            Console.ReadKey();
        }
    }
}

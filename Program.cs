namespace FaucetsCalculator
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Miner> miners = InitializeData.GetMiners();
        }
    }
}

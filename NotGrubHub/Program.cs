using NotGrubHub.Factories;
using System;

namespace NotGrubHub
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilityFactory.GetApp().Run();
            Console.WriteLine("== Program Ended ==");
        }
    }
}

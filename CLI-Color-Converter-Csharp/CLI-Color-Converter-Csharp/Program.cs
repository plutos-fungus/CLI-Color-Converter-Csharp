using System;
using System.Collections.Generic;

namespace CLI_Color_Converter_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================");
            Console.WriteLine("|| 1.   HEX --> RGB ||");
            Console.WriteLine("|| 2.   RGB --> HEX ||");
            Console.WriteLine("======================");
            Converter Con = new Converter();
            int check = 0;
            check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    Con.Converter_HEXRGB();
                    break;
                case 2:
                    Con.Converter_RGBHEX();
                    break;
                default:
                    Console.WriteLine("Please choose an option");
                    break;
            }
        }
    }
}

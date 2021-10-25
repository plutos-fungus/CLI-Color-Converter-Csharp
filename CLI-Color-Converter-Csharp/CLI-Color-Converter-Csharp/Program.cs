using System;
using System.Collections.Generic;

namespace CLI_Color_Converter_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.   HEX --> RGB");
            Console.WriteLine("2.   RGB --> HEX");

            int R;
            int G;
            int B;
            string HEX_R;
            string HEX_G;
            string HEX_B;
            string HEX;
            int check = 0;
            check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    HEX = Console.ReadLine();
                    Console.WriteLine(HEX[0]);
                    HEX_R = Convert.ToString(HEX[0]) + Convert.ToString(HEX[1]);
                    HEX_G = Convert.ToString(HEX[2]) + Convert.ToString(HEX[3]);
                    HEX_B = Convert.ToString(HEX[4]) + Convert.ToString(HEX[5]);
                    Console.WriteLine("HEX: " + HEX + " " + "HEX_R: " + HEX_R + " " + "HEX_G: " + HEX_G  + " " + "HEX_B: " + HEX_B);
                    R = Convert.ToInt32(HEX_R, 16);
                    G = Convert.ToInt32(HEX_G, 16);
                    B = Convert.ToInt32(HEX_B, 16);
                    Console.WriteLine("R: " + R);
                    Console.WriteLine("G: " + G);
                    Console.WriteLine("B: " + B);
                    break;
                case 2:
                    R = Convert.ToInt32(Console.ReadLine());
                    G = Convert.ToInt32(Console.ReadLine());
                    B = Convert.ToInt32(Console.ReadLine());
                    HEX_R = Convert.ToString(R, 16);
                    HEX_G = Convert.ToString(G, 16);
                    HEX_B = Convert.ToString(B, 16);
                    HEX = HEX_R + HEX_G + HEX_B;
                    Console.WriteLine(HEX);

                    break;
            }
        }
    }
}

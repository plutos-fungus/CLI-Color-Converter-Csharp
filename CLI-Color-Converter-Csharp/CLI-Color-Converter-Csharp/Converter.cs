using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Color_Converter_Csharp
{
    public class Converter
    {
        /*============ Properties ============*/
        public string HEX_R
        { get; set; }
        public string HEX_G
        { get; set; }
        public string HEX_B
        { get; set; }
        public string HEX
        { get; set; }
        public int R
        { get; set; }
        public int G
        { get; set; }
        public int B
        { get; set; }

        /*============ Methods ============*/
        public int Converter_HEXRGB()
        {
            HEX = Console.ReadLine();
            HEX_R = Convert.ToString(HEX[0]) + Convert.ToString(HEX[1]);
            HEX_G = Convert.ToString(HEX[2]) + Convert.ToString(HEX[3]);
            HEX_B = Convert.ToString(HEX[4]) + Convert.ToString(HEX[5]);
            Console.WriteLine("HEX: " + HEX + " " + "HEX_R: " + HEX_R + " " + "HEX_G: " + HEX_G + " " + "HEX_B: " + HEX_B);
            R = Convert.ToInt32(HEX_R, 16);
            G = Convert.ToInt32(HEX_G, 16);
            B = Convert.ToInt32(HEX_B, 16);
            Console.WriteLine("R: " + R);
            Console.WriteLine("G: " + G);
            Console.WriteLine("B: " + B);
            return 1;
        }
        public int Converter_RGBHEX()
        {
            R = Convert.ToInt32(Console.ReadLine());
            G = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            HEX_R = Convert.ToString(R, 16);
            HEX_G = Convert.ToString(G, 16);
            HEX_B = Convert.ToString(B, 16);
            HEX = HEX_R + HEX_G + HEX_B;
            Console.WriteLine(HEX);
            return 1;
        }
    }
}

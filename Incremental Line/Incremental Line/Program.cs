using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incremental_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int x2;
            int y1;
            int y2;
            int x;
            int y;
            int b;
            int slope;
            int loop;
            Console.WriteLine("                    Incremental Line Method");
            Console.WriteLine("How Many Points Do You Want To Get?\nPlease Enter :");
            loop=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter x1 Value :");
            x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2 Value :");
            x2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 Value :");
            y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 Value :");
            y2 = Int32.Parse(Console.ReadLine());
            slope = (y2 - y1) / (x2 - x1);
            Console.WriteLine("\nThe Slope Is :"+slope);
            b = y1 - slope * x1;
            Console.WriteLine("The b Is :" + b+"\n\n");
            for (int a = 0; a < loop;a++)
            {
                if (slope > 1)
                {

                    y = y1 + 1 + a;
                    x = (y - b) / slope;
                    Console.WriteLine("Next Point Is " + "(" + x + "," + y + ")");

                }
                else
                {
                    x = x1 + 1 + a;
                    y = slope * x + b;
                    Console.WriteLine("Next Point Is " + "(" + x + "," + y + ")");
                }
            }
            Console.ReadLine();
        }
    }
}

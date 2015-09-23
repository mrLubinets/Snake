using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1,x2,y2;
            x1 = 1;
            y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
            Console.ReadLine();

            
        }


        static void draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
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
            /*int x1, y1,x2,y2;
            x1 = 1;
            y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
            */

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 6;
            p1.sym = '#';
            p1.draw();

            Point p2 = new Point();
            p2.x = 6;
            p2.y = 6;
            p2.sym = '!';
            p2.draw();

            Console.ReadLine();

            
        }


      
    }
}
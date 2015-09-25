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
            

            Point_k p1 = new Point_k(1,10,'!');
            p1.draw();

            Point_k p2 = new Point_k(10,16,'f');
            p2.draw();

            HorizontalLine line_x = new HorizontalLine(1,4,5,'#');
            line_x.drow();

            VerticalLine line_y = new VerticalLine(1, 4, 5, '#');
            line_y.drow();
            Console.ReadLine();

            
        }


      
    }
}
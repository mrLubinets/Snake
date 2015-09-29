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
            Console.SetBufferSize(80,25);

            HorizontalLine line_x_up = new HorizontalLine(0,78,0,'#');
            HorizontalLine line_x_down = new HorizontalLine(0, 78, 24, '#');
            VerticalLine line_y_l = new VerticalLine(0, 24, 78, '#');
            VerticalLine line_y_r = new VerticalLine(0, 24, 0, '#');
            line_x_up.drow();
            line_x_down.drow();
            line_y_l.drow();
            line_y_r.drow();


            //Draw point snake

            Point_k p = new Point_k(1,1,'*');
            Snake snake = new Snake(p,20,Direction.RIGHT);
            snake.drow();
            snake.Move();

            Console.ReadLine();   
        }


      
    }
}
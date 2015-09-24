using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point_k
    {
        public int x, y;
        public char sym;

        public Point_k(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }

}

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

        public Point_k(Point_k p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset,Direction direction) {

                   if (direction == Direction.RIGHT) {
                x = x + offset;
            } else
                   if(direction == Direction.LEFT){
                x = x - offset;
            }
            else
                   if (direction == Direction.DOWN){
                y = y - offset;
            }
            else
                   if (direction == Direction.UP){
                y = y + offset;
            }
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{      //Сделать игру про DWARF
    class Snake : Figure
    {
  
        public Snake(Point_k  tail, int lenght, Direction direction) {

            pList = new List<Point_k>();
            for (int i = 0; i < lenght; i++)
            {
                Point_k p = new Point_k(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}

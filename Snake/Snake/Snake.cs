using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{      //Сделать игру про DWARF
    class Snake : Figure
    {
        Direction direction;
  
        public Snake(Point_k  tail, int lenght, Direction _direction) {

            direction = _direction;
            pList = new List<Point_k>();
            for (int i = 0; i < lenght; i++)
            {
                Point_k p = new Point_k(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point_k tail = pList.First();
            pList.Remove(tail);
            Point_k head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.draw();
        }

        public Point_k GetNextPoint() {

            Point_k head = pList.Last();
            Point_k nextPoint = new Point_k(head);
            nextPoint.Move(1 , direction);
            return nextPoint;
        }
    }
}

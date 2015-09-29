using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
       protected  List<Point_k> pList;


        public void drow()
        {
            foreach (Point_k p in pList)
                p.draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point_k> pList;

        public  VerticalLine(int yLeft, int yRight, int x, char sym) {

            pList = new List<Point_k>();

            for (int y = yLeft; y <= yRight; y++) {
                Point_k p = new Point_k(x,y,sym);
                pList.Add(p); 
            }


        }

        public void drow() {
            foreach (Point_k p in pList) {
                p.draw();
            }
        }


    }
}

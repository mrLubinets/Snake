using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine :Figure
    {
        

        public HorizontalLine(int xLeft, int xRight,int y, char sym)
        {
            pList = new List<Point_k>();

            for (int x = xLeft; x <= xRight; x++) {
                Point_k p = new Point_k(x,y,sym);
                pList.Add( p );
            }
    
        }


    }
}

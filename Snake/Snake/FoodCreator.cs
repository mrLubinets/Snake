using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{   
    class FoodCreator
    {    
        // Border map 
        int mapWidth;
        int mapHeight;
        // Icon food
        char sym;
        Random rnd;

        public FoodCreator(int mapWidth, int mapHeight, char sym) {
            this.mapWidth  = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point_k CreateFood() {
            rnd = new Random();
            int x = rnd.Next(2, mapWidth  - 1);
            int y = rnd.Next(2, mapHeight - 1);
            return new Point_k(x,y,sym);
        }
    }
}

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
            /*int x1, y1,x2,y2;
            x1 = 1;
            y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
            */

            Point_k p1 = new Point_k(1,10,'!');
          /*  p1.x = 1;
            p1.y = 6;
            p1.sym = '#';*/
            p1.draw();

            Point_k p2 = new Point_k(10,16,'f');
            /*p2.x = 6;
            p2.y = 6;
            p2.sym = '!';*/
            p2.draw();

            List<int> numList = new List<int>();
            numList.Add(7); // иницилизация первого элемента в списке
            numList.Add(1);
            numList.Add(1);


            int x = numList[0]; // обрвщиение к первому элементу списка
            int y = numList[1];
            int z = numList[2];

            //Вывод элементов через foreach()

         /*  foreach (int i in numList) {
               Console.WriteLine(i);
            }
            */

            //Удаление из списка 
            Console.WriteLine("Удаляем элемент из списка");
            Console.WriteLine(numList[0]);
            numList.Remove(1);
            Console.WriteLine(numList[0]);


            /*  foreach (int i in numList)
              {
                  Console.WriteLine(i);
              }


  */

            List <Point_k> pList = new List <Point_k>();
            pList.Add(p2);

            LIST l = new LIST();
            l.create_09();

            Console.ReadLine();

            
        }


      
    }
}
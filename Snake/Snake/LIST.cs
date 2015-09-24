using System;
using System.Collections.Generic; // без этого не собрать динамический список List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class LIST
    {

        public void create_09()
        {
            string[] asd = new string[10]; // статический список (потому что ограниченый изначально размер)

            // Динамический список (свободный в действиях)

            List<int> lol = new List<int>();
            // в <> пишится какие данные будет хранить список
            int[] dec = new int[] { 0, 2, 3, 4 }; //создали массив
            lol.AddRange(dec);// загрузили массив в список
           // lol.Remove(0); // удалит все элементы равные нулю
            //lol.RemoveAt(2);// удалит 2 по индексу элемент из списка
            //lol.RemoveRange(0, 2); // удали от индекса до индекса

            dec = lol.ToArray(); // выгрузка все элементов списка в массив

            // вывод элементов

            foreach (int i in lol) {
                Console.WriteLine("{0}", i);
            }

            for (int i = 0; i < lol.Count; i++) {
                Console.WriteLine("{0}", lol[i]);
            }
        }

    }
}

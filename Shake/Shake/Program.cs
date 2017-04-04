using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляр класса Point
            Point p1 = new Point();
            //Получаем данные для p1 из класса Point
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            //Вызываем метод Draw для отрисовки точки
            p1.Draw();

            //Создаем экземпляр класса Point
            Point p2 = new Point();
            //Получаем данные для p1 из класса Point
            p2.x = 3;
            p2.y = 3;
            p2.sym = '@';
            //Вызываем метод Draw для отрисовки точки
            p2.Draw();
            Console.ReadLine();
        }
    }
}

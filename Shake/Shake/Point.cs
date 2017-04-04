using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shake
{
    class Point
    {
        //Создали класс Point в котором описываем те данные с которыми мы будем работать
        public int x;
        public int y;
        public char sym;

        //Описываем метод Draw, который будет отрисовывать точку для будущего обращения к нему
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}

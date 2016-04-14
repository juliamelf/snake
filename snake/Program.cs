using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(88, 25);
                        
            // Отрисовка рамочки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            //Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Управление змейкой
            while (true)
            {
                if (Console.KeyAvailable) // была ли нажата какая-либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // получаем значение нажатой клавиши
                    snake.HandleKey(key.Key); // изменяем направление змейки
                }
                Thread.Sleep(100);
                snake.Move();
            }

            //Чтобы не отображался курсор
            Console.CursorVisible = false;
        }
       
    }
}

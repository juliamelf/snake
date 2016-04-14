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

            //Отрисовка стен - рамочки
            Walls walls = new Walls(88, 25);
            walls.Draw();           

            //Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            //Управление змейкой
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) //если змейка натолкнулась на препятствие или хвост, то гейм овер
                {
                    break;
                }
                if (snake.Eat(food)) // если змейка поела, то создаем новую еду, иначе змейка двигается дальше
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else //иначе - двигаемся дальше
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable) // была ли нажата какая-либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // получаем значение нажатой клавиши
                    snake.HandleKey(key.Key); // изменяем направление змейки
                }               
                
            }

            //Чтобы не отображался курсор
            Console.CursorVisible = false;
        }
       
    }
}

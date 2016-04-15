using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {

        //Поля класса
        Direction direction; 

        //Конструктор класса для создания экземпляра класса с переменными
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i=0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }

        //Метод класса, задает движение объекта (змейки)
        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();
        }
        
        //Метод класса, возвращает следующую точку для змейки
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }   
        
        //Метод класса, определяет не встретилась ли змейка со своим хвостом
        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                {
                    return true;
                }
            }
            return false;
        } 
        
        //Метод класса для распознавания нажатия клавиш и изменения направления змейки
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }    

        //Метод класса для распознавания съела ли змейка еду или нет, возвращает true/false
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food)) // если точка головы совпадает с точкой еды, то змейка ест
            {
                food.sym = head.sym; //меняется символ еды на символ змейки
                plist.Add(food); //добавляется длина змейки
                return true;
            }
            else
                return false;
        }
    }
}

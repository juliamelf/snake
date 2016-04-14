using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {

        // Переменные класса 
        public int x;
        public int y;
        public char sym;

        //Конструктор класса, задает значение переменных для объекта класса (точки)
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        //Конструктор класса, задает значение переменных, аналогичные существующему объекту (точке) - копирует объект
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        //Метод класса, задает смещение объекта класса (точки) в определенном направлении на определенное значение
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y + offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y - offset;
            }

        }

        //Метод класса, рисует объект класса (точку)
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        //Метод класса, стирает объект класса (точку) - замещает существующий символ на пустой
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        //Метод с магией
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {

        //Переменные класса
        List<Figure> wallList;

        //Конструктор класса
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>(); //присваиваю значение переменной

            // Отрисовка рамочки
            HorizontalLine upline = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);

        }

        //Метод класса, определяющий столкновение со стеной
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }

            }
            return false;
        }

        //Метод класса, отрисовывающий стены
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}

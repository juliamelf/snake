using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        //Поля класса - фигура состоит из списка точек
        protected List<Point> plist;

        //Метод класса, рисующий точки из списка
        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }

        //Метод класса, определяющий столкновение с фигурой
        internal bool IsHit(Figure figure)
        {
            foreach (var p in plist)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        //Метод класса, определяющий пересечение точек
        private bool IsHit(Point point)
        {
            foreach(var p in plist)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;

        }
    }
}

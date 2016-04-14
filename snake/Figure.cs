using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        //Переменные класса - фигура состоит из списка точек
        protected List<Point> plist;

        //Метод класса, рисующий точки из списка
        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}

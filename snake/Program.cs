using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            Point p3 = new Point(7, 10, '@');
            //p3.Draw();

            Point p4 = new Point(9, 10, '^');
            //p4.Draw();

            /*List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);   
            
            foreach(int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0);
            */

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);

            foreach(Point i in plist)
            {
                i.Draw();
            }

            Console.ReadLine();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure
    {
        protected List<Point> pList;

        public void DrawLine()
        {
            foreach (var item in pList)
            {
                item.Draw();
            }
        }
    }
}

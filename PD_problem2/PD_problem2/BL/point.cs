using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PD_problem2.BL;

namespace PD_problem2.BL
{
    class point
    {
        private int x;
        private int y;

        public point()
        {
            x = 0;
            y = 0;
        }

        public point(int x , int y )
        {
            this.x = x;
            this.y = y;
        }

        public int getX() { return x; }
        public void setX(int x) { this.x = x; }

        public int getY() { return y; }
        public void setY(int y) { this.y = y; }

        public void setXY(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}

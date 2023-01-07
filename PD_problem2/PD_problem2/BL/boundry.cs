using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PD_problem2.BL;
namespace PD_problem2.BL
{
    class boundry
    {
        private point topLeft;
        private point topRight;
        private point bottomLeft;
        private point bottomRight;

        public point gettopLeft() { return topLeft; }
        public void settopLeft(point p) { topLeft = p; }

        public point gettopRight() { return topRight; }
        public void settopRight(point p) { topRight = p; }

        public point getbottomLeft() { return bottomLeft; }
        public void setbottomLeft(point p) { bottomLeft = p; }

        public point getbottomRight() { return bottomRight; }
        public void setbottomRight(point p) { bottomRight = p; }


        public boundry()
        {
            topLeft = new point(0, 0);
            topRight = new point(90, 0);
            bottomLeft = new point(0, 90);
            bottomRight = new point(90, 90);
        }

        public boundry(point topLeft, point topRight, point bottomLeft, point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }

 
    }
}

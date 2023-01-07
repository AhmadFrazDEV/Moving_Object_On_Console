using System;
using static System.Console;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PD_problem2.BL;
using PD_problem2.gameObject_DL;
using PD_problem2.GameObject_UI;

namespace PD_problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] dragon = new char[6, 6]
            {
              { ' ',' ','#',' ',' ',' '},
              { ' ',' ','#','#',' ',' '},
              { '@','@','#','#','#','='},
              { '@','@','#','#','#','='},
              { ' ',' ','#','#',' ',' '},
              { ' ',' ','#',' ',' ',' '}
            };


            boundry b = new boundry(new point(0, 0), new point(0, 90), new point(90, 0), new point(90, 90));
            gameObjects g = new gameObjects(dragon, new point(5,5), b, "LeftToRight");
            
            int count = 1;

            while (true)
            {
                Thread.Sleep(100);
            
                    Clear();
                if(count % 5 == 1)
                {
                    g.setDirection("projectile");
                }
                    g.erase();
                    g.move();
                    g.draw();
                count++;
                
            }

            ReadKey();
        }
    }
}

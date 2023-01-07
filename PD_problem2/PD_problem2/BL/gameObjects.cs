using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PD_problem2.BL;

namespace PD_problem2.BL
{
    class gameObjects
    {

        private char[,] shape;
        private point startingPoint;
        private boundry premises;
        private string direction;
        
        public char[,] getArray() { return  shape; }
        public void setArray(char [,] shape) { this.shape = shape; }

        public point getStartingPoint() { return startingPoint; }
        public void setstartingPoint(point p) { startingPoint = p; }

        public boundry getPremises() { return premises; }
        public void setpremises(boundry p) { premises = p; }

        public string getDirection() { return direction; }
        public void setDirection(string d) { direction = d; }


        public gameObjects()
        {
            shape = new char[1, 3]; 
            startingPoint = new point();
            premises = new boundry();
            direction = "LefttoRight";
        }

        public gameObjects(char[,] shape, point b)
        {
            this.shape = shape;

            startingPoint = b;

    
        }

        public gameObjects(char [,] shap , point p , boundry b , string direction)
        {
            this.shape = shap;
            startingPoint = p;
            premises = b;
            this.direction = direction;
        }



        public void move()
        {
            int count = 1;
            if (direction == "LeftToRight")
            {
                if (startingPoint.getX() + 1 != premises.getbottomRight().getX())
                {
                    startingPoint.setX(startingPoint.getX() + 1);
                }
                count = 0;
            }

            else if (direction == "Righttoleft")
            {
                if (startingPoint.getX() - 1 != premises.gettopLeft().getX())
                {
                    startingPoint.setX(startingPoint.getX() - 1);
                }
                count = 0;
            }


            else if (direction == "patrol")
            {
                if (startingPoint.getX() - 1 != premises.gettopLeft().getX())
                {
                    startingPoint.setX(startingPoint.getX() - 1);
                }
                else
                {
                    direction = "LeftToRight";
                }
                count = 0;
            }


            else if (direction == "projectile")
            {
                if (count < 4)
                {
                    if (startingPoint.getX() + 1 < premises.gettopRight().getX())
                    {
                        startingPoint.setX(startingPoint.getX() + 1);
                        if (startingPoint.getY() - 1 > premises.gettopRight().getY())
                        {
                            startingPoint.setY(startingPoint.getY() - 1);
                        }
                    }
                }
                else if (count < 6)
                {
                    if (startingPoint.getX() + 1 != premises.getbottomRight().getX())
                    {
                        startingPoint.setX(startingPoint.getX() + 1);
                    }
                }
                else if (count < 10)
                {
                    if (startingPoint.getX() + 1 < premises.getbottomRight().getX())
                    {
                        startingPoint.setX(startingPoint.getX() + 1);
                        if (startingPoint.getY() + 1 < premises.getbottomRight().getY())
                        {
                            startingPoint.setY(startingPoint.getY() + 1);
                        }
                    }
                }

            }


            else if (direction == "diagonal")
            {
                if (startingPoint.getX() + 1 < premises.getbottomRight().getX())
                {
                    startingPoint.setX(startingPoint.getX() + 1);
                    if (startingPoint.getY() + 1 < premises.getbottomRight().getY())
                    {
                        startingPoint.setY(startingPoint.getY() + 1);
                    }
                }
                count = 0;
            }
            count++;
        }

        public  void draw()
        {
            int x = startingPoint.getX();
            int y = startingPoint.getY();
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                SetCursorPosition(x , y);
                for (int j = 0; j < shape.GetLength(0); j++)
                {
                    
                    Write(shape[i, j]);
                }
                WriteLine();
                y++;
            }
        }


        public void erase()
        {

            int x = startingPoint.getX();
            int y = startingPoint.getY();
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                SetCursorPosition(x , y);
                for (int j = 0; j < shape.GetLength(0); j++)
                {
                    Write(" ");
                }
                y++;
            }
        }
    }
}

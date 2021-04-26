using System;

namespace CirclesSquaresTestingInGeneral
{
    public class Circle
    {
        public static int CircleAres(int radius)
        {
            return 2 * (radius * radius);
        }

        public static double CircleArea(double radius)
        {
            return Math.Round(2 * (radius * radius), 4);
        }
    }

    public class Rectangle
    {
        public static int RectangleArea(int side1, int side2, int side3)
        {
            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return side1 * side2 * side3;
            }
            else
            {
                throw new InvalidOperationException("At least 2 sides of this figure have to be equal in order to call it a rectangle!");
                //Ain't gonna finish this cuz I haven't been asked to do so.
                //Yet this was done to show that the process of adding new figures is relatively simple.
                //Description of the error doesn't really seem to make any sense.
            }
        }

        public static double RectangleArea(double side1, double side2, double side3)
        {
            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return side1 * side2 * side3;
            }
            else
            {
                throw new InvalidOperationException("At least 2 sides of this figure have to be equal in order to call it a rectangle!");
            
                //Same applies here.
            }
        }
    }

    public class Triangle
    {
        private static double s, result;

        public static double TriangleArea(double side1, double side2, double side3)
        {
            s = (side1 + side2 + side3) / 2;
            result = s(s - side1)(s - side2)(s - side3);
            return result;

            //Calculation is done by using Heron's formula
        }

        public static bool IsTriangleEquilateral(int side1, int side2, int side3)
        {
            if (side1 == side2 & side2 == side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsTriangleEquilateral(double side1, double side2, double side3)
        {
            if (side1 == side2 & side2 == side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

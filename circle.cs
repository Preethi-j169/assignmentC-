using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_Csharp
{
    class circle
    {
        
        double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double CalcDiameter()
        {
            return 2 * radius;
        }

        public double CalcArea()
        {
            return Math.PI * radius * radius;
        }





    }

    class CircleTest
    {
        public static void Main()
        {
            circle c1 = new circle();
            c1.SetRadius(2);

            Console.WriteLine(c1.GetRadius());
            Console.WriteLine(c1.CalcDiameter());
            Console.WriteLine(c1.CalcArea());

        }
    }
}
   

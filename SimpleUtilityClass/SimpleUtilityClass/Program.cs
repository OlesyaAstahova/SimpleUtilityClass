using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("***** Fun with Static Classes *****\n");

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            //TimeUtilClass u = new TimeUtilClass();
            
            Car viper = new Car();
            viper.TurnOnRadio(false); */

            Shape[] myShapes = new Shape[3];
            myShapes[0] = new Hexagon();
            myShapes[1] = new Circle();
            myShapes[2] = new Hexagon();

            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();
        }
    }
}

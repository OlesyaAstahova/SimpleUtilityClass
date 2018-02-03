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

           
            */

            Car viper = new Car();
            viper.TurnOnRadio(false);
            Console.ReadLine();
        }
    }
}

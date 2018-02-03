﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    /*
    static class TimeUtilClass
    {

        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
     }
        

    class Radio
    {
        public void Power (bool turnOn)
        {
            Console.WriteLine("Radio on: {0}", turnOn);
        }
    }

    class Car
    {
        private Radio myRadio = new Radio();
        public void TurnOnRadio (bool onOff)
        {
            myRadio.Power(onOff);
        }
    }
   */

    class Shape
    {

        public virtual void Draw()
        {
     
        }
       
    }
    class Circle:Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Я - круг");
        }
    }
    class Hexagon:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Я - гексагон");
        }
    }
   

}

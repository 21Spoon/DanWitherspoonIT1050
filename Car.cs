using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_Week2
{
    class Car
    {
        public string make;
        public string model;
        public string color;

        public int year;
        int Speed;
        int TopSpeed;

        int accelerate()
        {
            Speed = Speed + 1;
            return Speed;
        }
    }
}

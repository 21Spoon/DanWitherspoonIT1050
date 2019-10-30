using System;

namespace InClass_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myMobile = new Car();
            myMobile.make = "Jeep";
            myMobile.model = "Liberty";
            myMobile.color = "Blue";

            Console.WriteLine("Enter the year of your car ");
            //myMobile.year = Console.Readline();
            myMobile.year = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("I have a " + myMobile.color + " " + myMobile.make + " " + myMobile.model);
            Console.WriteLine("I have a {0} {1} {2} {3}", myMobile.color, myMobile.make, myMobile.model, myMobile.year
                ); ;
        }   
    } 
}

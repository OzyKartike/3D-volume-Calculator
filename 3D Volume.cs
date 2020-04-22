using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/*
 NameSpace Kartike_project_2
 * ICS
 * My code which is not to be taken seriously and isnt fully done but it is the best i have.
 * Kartike Chaudhari
 * 16/02/2020
 * Notes


 */

namespace Kartike_project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            double e;
            double f;
            double answer;
            double answer2;
            double answer3;
            double answer4;
            Console.WriteLine("Hello Master. I am your virtual assitant, Computron. What is your name");
            string name = Console.ReadLine();
            Console.WriteLine(" Hello " + name + ", my task today is to help you figure out the volume for one of these four shapes: Cube, Sphere, Cone, and/or Cylinder");
            Console.WriteLine("Please type out the name of the shape you would like me to find the volume for");
            string shape1 = Console.ReadLine().ToLower();
            shape1.Trim();
            if (shape1 == "cube")
            {
                Console.WriteLine("Alright, we will be solving for the volume of a cube using this formula: A^3. Please enter the value of A.");
                a = Convert.ToDouble(Console.ReadLine());
                answer = a * a * a;
                Console.WriteLine("Computron is calculating work for " + name)
                Thread.Sleep(2000);
                Console.WriteLine("The answer for the volume of this cube given your dimensions is " + answer);
                Console.WriteLine("It was a pleasure to calculate this answer with you. Now it seems I must bid you a due. If you need help finding the volume of any of the four shapes listed below run my program again and find out. Bye!");
            }
            if (shape1 == "Sphere")
            {
                Console.WriteLine("The shape you have chosen is a Sphere. The formula to solve the volume of the sphere is (4/3)*(3.1416)*(r^3). PLease enter the value of the radius of the sphere.");
                b = Convert.ToDouble(Console.ReadLine());
                answer2 = (4 / 3) * (3.1316) * (b * b * b);
                Console.WriteLine("Computron is calculating volume of sphere");
                Thread.Sleep(2000);
                Console.WriteLine("The Volume of the Sphere is " + answer2);
                Console.WriteLine("It was a pleasure to calculate this answer with you. Now it seems I must bid you a due. If you need help finding the volume of any of the four shapes listed below run my program again and find out. Bye!");
            }
            if (shape1 == "Cone")
            {
                Console.WriteLine("We will be solving for the volume of a cone. The formula to find the volume of a cone is (1/3) * (3.1416) * (r^2) * h. Please input the value of the radius of the cone.");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The Radius of the cone is " + c + ". Now please enter the value of the height of the cone.");
                d = Convert.ToDouble(Console.ReadLine());
                answer3 = (1 / 3) * (3.1416) * (c * c) * (d);
                Console.WriteLine("Calculating the answer");
                Thread.Sleep(2000);
                Console.WriteLine(name + ", Computron has found out the volume of the cone. The answer is: " + answer3);
                Console.WriteLine("It was a pleasure to calculate this answer with you. Now it seems I must bid you a due. If you need help finding the volume of any of the four shapes listed below run my program again and find out. Bye!");
            }
            if (shape1 == "Cylinder")
            {
                Console.WriteLine("We will solve for the volume of this cylinder. The formula to solve for the volume of a cylinder is: (3.1416) * (r^2) * (h). PLease enter the radius of this cylinder");
                e = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your radius for the cylinder is " + e + ".  Now please enter the height of your cylinder.");
                f = Convert.ToDouble(Console.ReadLine());
                answer4 = (3.1416) * (e * e) * (f);
                Console.WriteLine("Calculating the volume");
                Thread.Sleep(2000);
                Console.WriteLine("The volume for your cylinder is " + answer4);
                Console.WriteLine("It was a pleasure to calculate this answer with you. Now it seems I must bid you a due. If you need help finding the volume of any of the four shapes listed below run my program again and find out. Bye!");
            }
            Console.ReadLine();
        }
    }
}

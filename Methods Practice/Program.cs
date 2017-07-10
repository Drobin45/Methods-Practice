using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Methods are a tool for us to create reusable pieces of code.
            //Methods are a way of us collecting a series of instructions and then call...
            //...them when we need them.
            //Methods are ALWAYS part of a class. Methods are ALWAYS children of classes.
            //This means a method will NEVER be created inside another method or member of the class.
            // However, methods are frequently CALLED inside of another class or method.  

            //Console.WriteLine("Hello. Please enter the first nuimber to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);
            //Console.WriteLine("The sum of your numbers is " + answer);

            //RobotWarning("Will Robinson");

            string myBirthMonth = "September";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);

            Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle {1}.", myVehicle, myFriendVehicle);




        }
                
        //"public" is an access modifier, methods always have these.
            //Specifically, "Public" allows entire system to use the following method (Below AND Above it, I believe)
        // The first int is a "Return Type"
        // Method Name "Add" is in Pascal case, not cammel case like everything else
            //Pascal case is with every word of an object is capitalized, even the first word.

        // The structure of a Method is- Access Modifier "public"- Return Type "static"- Method name "Add"- Parenthesis with variables
        
            //Method Header

        public static int Add(int firstNumber, int secondNumber)

            // Static- It means we don't have to worry about objects. Further explanation later.

            //Method body
            // A complete Method with a Header and Body is called a method declaration. 
        {

            int sum = firstNumber + secondNumber;

            return sum;
            // The "return" keyword takes whatever value is determined by using this method...
            //... and sends that value back to where I call my method.
        }

        //If you have a method that does not have a return value, you would use the keyword
        //... "void". When we have a "void" return type we DON'T need to use the keyword "return".

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!!");
        }

        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }
    }
}

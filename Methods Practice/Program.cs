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
            //Notes One
            //Methods are a tool for us to create reusable pieces of code.
            //Methods are a way of us collecting a series of instructions and then call...
            //...them when we need them.
            //Methods are ALWAYS part of a class. Methods are ALWAYS children of classes.
            //This means a method will NEVER be created inside another method or member of the class.
            // However, methods are frequently CALLED inside of another class or method.  


            //Example one
            //Console.WriteLine("Hello. Please enter the first nuimber to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);
            //Console.WriteLine("The sum of your numbers is " + answer);

            //----------------------------------------------------------------------

            //Examples two and three
            //RobotWarning("Will Robinson");

            //string myBirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle {1}.", myVehicle, myFriendVehicle);

            //-----------------------------------------------------------------------
            //Example Three
            //double hoursWorked = 42.3d;
            //double hourlyWage = 12.50d;

            //Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorked, hourlyWage));

            //Method used for this example
            //    public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
            //{
            //    //This method should calulate the monthly wage
            //    double monthlyWage = ((hoursWorkedWeekly * 52) * hourlyWage) / 12;
            //    return monthlyWage;
            //}


            //-----------------------------------------------------------------------
            //Practice One

            //string myName = "Daniel";
            //string myFood = "Pizza";
            //FavoriteFood(myName, myFood);

            //----------------------------------------------------------------------
            //Practice Two

            //int myAge = 35;
            //RetirementCalculator(myAge);

            //-------------------------------------------------------------------------------
            //Practice three        

            //Create two methods of your choosing. At least one of the methods should have a non-void...
            //... return type.
            //Both of the methods should take at least one parameter.
            //Remember, when naming your method that it should represent what your method does
            //Your method should only aim to accomplish one thing. 
            // To be continued....

            //double mangoes = 1;
            //double moneyLeft = 999.98d;
            //Console.WriteLine("You can buy {0} mangoes", )

            //Method for practice three, problem one
        //public static void SnackMoney(double moneyLeft, double costOfSnacks)
        //{
        //    double numberOfSnacks = (moneyLeft / costOfSnacks);
        //}




    } //All below this are methods
                                            //Notes Two     
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

        //Practice One
        //Create a method called FavoriteFood
        //It should take two string parameters. One representing a name, and the other representing...
        // ... a favorite food.
        // The return type should be void
        //The method should concatenate
        //Complete


        public static void  FavoriteFood(string name, string food)
        {

            Console.WriteLine("Because your name is " + name + ",your favorite food is " + food);
        }

        //Practice Two
        //Create a method called RetirementCalculator
        //It should take an int as a parameter representing the user's age
        //The method should calculate how many more years until the user retires using 65 as the...
        // ... age of retirement.
        // The return type should be void
        //Once it calculated the user's retirement age it should print
        // "The user will retire in X years" where X represents the value that was calculated."
        //Complete

        public static void RetirementCalculator (int userAge)
        {
            int calculate = 65 - userAge;
            Console.WriteLine("You will retire in " + calculate + " years." );
        }

        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //This method should calulate the monthly wage
            double monthlyWage = ((hoursWorkedWeekly * 52) * hourlyWage) / 12;
            return monthlyWage;            
        }

        //Practice Three Method

        public static double SnackMoney(double moneyLeft, double costOfSnacks)
        {
            double numberOfSnacks = (moneyLeft / costOfSnacks);
            return numberOfSnacks;          
        }

    }
}

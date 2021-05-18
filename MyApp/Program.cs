using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gives an output to proof functionality
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Lets try wether this will merge");
            System.Console.WriteLine("ups die sollte doch auch noch mit rein!");
            System.Console.WriteLine("Diese Line soll aber bleiben...");
            System.Console.WriteLine("Diese Line aber eigentlich auch...");
            System.Console.WriteLine("Und was passiert jetzt?");
            //calls the function below
            printHello();
            //calls the function from another file
            PrintClass.printSomething();
        }

        public static void printHello(){
            System.Console.WriteLine("Hello!");
            
        }
    }
}

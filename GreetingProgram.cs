using System;
class GreetingProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the total number of your enrolled courses: ");
        int course = (Convert.ToInt32(Console.ReadLine()));

        Console.Write("Enter the price of your favorite book: ");
        double price = (Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("==================================================");
        //displaying the input from the user
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total enrolled course: " + course);
        Console.WriteLine("Price of my favorite book: " + price);
    }
}
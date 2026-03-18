using System;
using CarObjectSpace;
public class Program
{
    public static void Main(/* string model, int speed  */)
    {
        Console.WriteLine("Enter car model:");
        string model = Console.ReadLine() ?? string.Empty;
        Car car = new Car(model);

        Console.WriteLine($"Let's take a {car.Model} for a spin!");
        car.Accelerate();
        Console.WriteLine($"Speed: {car.Speed}");
        
        car.Accelerate();
        Console.WriteLine($"Speed: {car.Speed}");
        
        car.Brake();
        Console.WriteLine($"Speed is at: 70 nah im just kidding pump the breaks");
        Console.WriteLine($"Speed: {car.Speed}");
        



        /* 
        Main must:

        Ask the user for a car model
        Create one Car object using new
        Call Accelerate() twice
        Call Brake() once
        Display the car’s speed after each method call

        Car.cs must be in a different namespace than Program.cs
        */
    }
}
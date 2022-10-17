// Created by: Mikey Gloriani
// Created on: Oct 2022
//
// This program displays, the area of a triangle


using System;

class Program {
    public static void Main (string[] args) {
        // This function accepts user input
        int Base;
        int height;
        int area;

        Console.WriteLine("This program calculates the area and perimeter of a rectangle.");
        Console.WriteLine("");

        Console.Write("Enter the base (cm): ");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        area = (Base * height)/2;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");

        Console.WriteLine("\nDone.");
    }
}

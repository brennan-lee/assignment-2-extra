// Created by: Brennan Lee
// Created on: Sep 2020
//
// This program calculates area of a rhombus

using System;

class Program
{
    public static void Main(string[] args)
    {
        int height;
        int baseOfRhombus;
        int area;

        Console.WriteLine("This program calculates the area of a rhombus.");
        Console.WriteLine("");

        Console.WriteLine("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the baseOfRhombus (cm): ");
        baseOfRhombus = Convert.ToInt32(Console.ReadLine());

        area = height * baseOfRhombus;
        Console.WriteLine("");
        Console.WriteLine("The area is: " + area + " cm². ");
        Console.WriteLine("\nDone.");
    }
}

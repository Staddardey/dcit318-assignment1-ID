using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        // Prompt the user to enter the lengths of the sides
        Console.Write("Enter the length of side 1: ");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the length of side 2: ");
        double side2 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the length of side 3: ");
        double side3 = double.Parse(Console.ReadLine());
        
        // Check the triangle type based on side lengths
        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is scalene.");
        }
    }
}


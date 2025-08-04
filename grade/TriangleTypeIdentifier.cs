using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
        else
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

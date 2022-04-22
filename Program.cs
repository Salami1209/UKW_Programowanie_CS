using System;
public class Exercise8
{
    public static void Main()
    {
        int num1, num2, num3;
        Console.Write("Wprowadź pierwszą liczbę: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Wprowadź drugą liczbę: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Wprowadź trzecią liczbę: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("Pierwsza liczba jest największa.");
            }
            else
            {
                Console.Write("Trzecia liczba jest największa.");
            }
        }
        else if (num2 > num3)
            Console.Write("Druga liczba jest największa.");
        else
            Console.Write("Trzecia liczba jest największa.");
    }
}
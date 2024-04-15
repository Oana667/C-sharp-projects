using System;
public class FibonacciSequence
{
    public static void Main(string[] args)
    {
        int F1 = 0, F2 = 1, F3, i, elementsnr;

        Console.Write("Enter the number of elements: ");

        elementsnr = int.Parse(Console.ReadLine());

        Console.Write(F1 + " " + F2 + " "); 
                                            
        for (i = 2; i < elementsnr; ++i)    
        {
            F3 = F1 + F2;
            Console.Write(F3 + " ");
            F1 = F2;
            F2 = F3;
        }
    }
}
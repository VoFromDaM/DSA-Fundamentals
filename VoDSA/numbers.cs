namespace VoDSA;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("W Assignment btw!");
    
    {
       
        {
            int Number1 = 0, Number2 = 1, nextNumber, number;
            Console.Write("Enter the no. upto which print the Fibonacci series : ");
            number = int.Parse(Console.ReadLine());
            
            Console.Write(Number1 + " " + Number2 + " ");
            nextNumber = Number1 + Number2;
            
            for (int i = 2; nextNumber < number; i++)
            {
                Console.Write(nextNumber + " ");
                Number1 = Number2;
                Number2 = nextNumber;
                nextNumber = Number1 + Number2;
            }
            
            Console.ReadKey();
        }
    }
    }}
    





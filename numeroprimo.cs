using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("{0} è un numero primo.", num);
        }
        else
        {
            Console.WriteLine("{0} non è un numero primo.", num);
        }
    }
}

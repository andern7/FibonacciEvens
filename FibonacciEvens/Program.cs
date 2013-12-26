using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvens
{
    class Program
    {
    public static int Fibonacci(int n)
    {
	int a = 0;
	int b = 1;
   
	// In N steps compute Fibonacci sequence iteratively.
	for (int i = 0; i < n; i++)
	{
	    int temp = a;
	    a = b;
	    b = temp + b;
	}
	return a;
    }

    static void Main()
    {
    List<int> FibEvens = new List<int>();
    int FibSum; 
	for (int i = 0; i < 34; i++)
	{
        ////Console.WriteLine(Fibonacci(i));
        if (Fibonacci(i)%2==0)
        {
            FibEvens.Add(Fibonacci(i));
        }
        
        //Console.WriteLine(FibEvens);
       
	}
    foreach (int _i in FibEvens)
    {
        Console.WriteLine(_i.ToString());
    }
    FibSum = FibEvens.Sum();
    Console.WriteLine(FibSum);
    Console.ReadLine();
    }
}
        }
    


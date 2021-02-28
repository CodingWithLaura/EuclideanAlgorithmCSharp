using System;

namespace EuklidischerAlgorithmus
{
    class Program
    {
	static void Main(string[] args)
	{
	    int a = 0;
	    int b = 0;

	    bool test1 = int.TryParse(args[0], out a);
	    bool test2 = int.TryParse(args[1], out b);

	    if(!test1 || !test2)
	    {
		Console.WriteLine("Please only type in numbers for a und b");
            }
            ggT(a, b);  
	}

	static void ggT(int a, int b)
	{
	    //a=9 b=16
	    if(b > a){  // swutch with two varriables
	        a = b + a; 
	        b = a;     
	        a = a - b; 
	    }		  
	  
	    while(b != 0)
	    {
	        int rest = a % b; 
                a = b;
	        b = rest;
	        Console.WriteLine($"{a} {b} {rest}");
	    }
	  
            Console.WriteLine($"Der ggT ist {a}"); 
        }
    }
}

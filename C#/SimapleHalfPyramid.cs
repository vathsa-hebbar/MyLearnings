using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks; 

class SimapleHalfPyramid
{  
    static void Main(string[] args)  
    {  
        int count = 6;  
        string print = "*";  
        string space = " ";  
        for (int i = 0; i < count; i++)  
        {  
            for (int j = count - 1; j > i; j--)  
            {  
                Console.Write(space);  
            }  
            Console.WriteLine(print);  
            print = print + "*";  
        }  
        Console.ReadLine();  
    }  
}  

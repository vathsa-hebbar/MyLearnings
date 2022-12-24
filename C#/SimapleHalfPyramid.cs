// using System;  
// using System.Collections.Generic;  
// using System.Linq;  
// using System.Text;  
// using System.Threading.Tasks; 

// //type - 1
// class SimapleHalfPyramid
// {  
//     static void Main(string[] args)  
//     {  
//         int count = 6;  
//         string print = "*";  
//         string space = " ";  
//         for (int i = 0; i < count; i++)  
//         {  
//             for (int j = count - 1; j > i; j--)  
//             {  
//                 Console.Write(space);  
//             }  
//             Console.WriteLine(print);  
//             print = print + "*";  
//         }  
//         Console.ReadLine();  
//     }  
// }  
// //output:
// //      *
// //     **
// //    ***
// //   ****
// //  *****
// // ******

// //type - 2

// class SimapleHalfPyramid
// {
//     //Program to print a Half pyramid
//     static void Main(string[] args)
//     {
//         int a, b, rows;
//         Console.Write("Enter number of rows:\t");
//         rows = Convert.ToInt16(Console.ReadLine());
//         for (a = 1; a <= rows; a++)
//         {
//             for (b = 1; b <= a; b++)
//             {
//                 Console.Write("* ");
//             }
//             Console.WriteLine();
//         }
//         Console.Read();
//     }
// }

// // //output
// // * 
// // * * 
// // * * * 
// // * * * * 
// // * * * * *

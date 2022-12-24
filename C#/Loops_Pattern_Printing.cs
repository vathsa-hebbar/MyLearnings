// // C# Program to illustrate the
// // above given pattern of numbers
// using System;

// class GFG {

// 	public static void Main()
// 	{

// 		int n = 5, i, j, num = 1, gap;

// 		gap = n - 1;

// 		for (j = 1; j <= n; j++) {
// 			num = j;

// 			for (i = 1; i <= gap; i++)
// 				Console.Write(" ");

// 			gap--;

// 			for (i = 1; i <= j; i++) {
// 				Console.Write(num);
// 				num++;
// 			}
// 			num--;
// 			num--;
// 			for (i = 1; i < j; i++) {
// 				Console.Write(num);
// 				num--;
// 			}
// 			Console.WriteLine();
// 		}
// 	}
// }

// //output
// //    1
// //   232
// //  34543
// // 4567654
// //567898765




// //set-2
// // C# Program to illustrate the
// // above given pattern of numbers
// using System;

// class GFG {

// 	public static void Main()
// 	{

// 		int n = 5, i, j, gap;

// 		gap = n - 1;

// 		for (j = 1; j <= n; j++) {

// 			for (i = 1; i <= gap; i++)
// 				Console.Write(" ");

// 			gap--;

// 			for (i = 1; i <= j; i++) {
// 				Console.Write(" "+i);
// 			}
// 			Console.WriteLine();
// 		}
// 	}
// }

// //output
// //     1
// //    1 2
// //   1 2 3
// //  1 2 3 4
// // 1 2 3 4 5

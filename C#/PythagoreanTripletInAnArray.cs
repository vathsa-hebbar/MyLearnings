// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// class PythagoreanTripletInAnArray
// {
 
//     // Returns true if there is a triplet
//     // with following property A[i]*A[i]
//     // = A[j]*A[j]+ A[k]*[k] Note that
//     // this function modifies given array
//     static bool isTriplet(int[] arr, int n)
//     {
 
//         // Square array elements
//         for (int i = 0; i < n; i++)
//             arr[i] = arr[i] * arr[i];
 
//         // Sort array elements
//         Array.Sort(arr);
 
//         // Now fix one element one by one
//         // and find the other two elements
//         for (int i = n - 1; i >= 2; i--) {
//             // To find the other two elements,
//             // start two index variables from
//             // two corners of the array and
//             // move them toward each other
//             // index of the first element
//             // in arr[0..i-1]
//             int l = 0;
 
//             // index of the last element
//             // in arr[0..i - 1]
//             int r = i - 1;
//             while (l < r) {
 
//                 // A triplet found
//                 if (arr[l] + arr[r] == arr[i])
//                     return true;
 
//                 // Else either move 'l' or 'r'
//                 if (arr[l] + arr[r] < arr[i])
//                     l++;
//                 else
//                     r--;
//             }
//         }
 
//         // If we reach here, then
//         // no triplet found
//         return false;
//     }
 
//     // Driver Code
//     public static void Main()
//     {
//         int[] arr = { 3, 1, 4, 6, 5 };
//         int arr_size = arr.Length;
//         if (isTriplet(arr, arr_size) == true)
//             Console.WriteLine("Yes");
//         else
//             Console.WriteLine("No");
//     }
// }


// // STATIC PROGRAM 
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// class PythagoreanTripletInAnArray
// {
 
//     // Returns true if there is a triplet
//     // with following property A[i]*A[i]
//     // = A[j]*A[j]+ A[k]*[k] Note that
//     // this function modifies given array
//     static bool isTriplet(int[] arr, int n)
//     {
 
//         // Square array elements
//         for (int i = 0; i < n; i++)
//             arr[i] = arr[i] * arr[i];
 
//         // Sort array elements
//         Array.Sort(arr);
 
//         // Now fix one element one by one
//         // and find the other two elements
//         for (int i = n - 1; i >= 2; i--) {
//             // To find the other two elements,
//             // start two index variables from
//             // two corners of the array and
//             // move them toward each other
//             // index of the first element
//             // in arr[0..i-1]
//             int l = 0;
 
//             // index of the last element
//             // in arr[0..i - 1]
//             int r = i - 1;
//             while (l < r) {
 
//                 // A triplet found
//                 if (arr[l] + arr[r] == arr[i])
//                     return true;
 
//                 // Else either move 'l' or 'r'
//                 if (arr[l] + arr[r] < arr[i])
//                     l++;
//                 else
//                     r--;
//             }
//         }
 
//         // If we reach here, then
//         // no triplet found
//         return false;
//     }
 
//     // Driver Code
//     public static void Main()
//     {   
        
//         // int[] arr = {10, 4, 6, 12, 5};
//         // int arr_size = arr.Length;
//         Console.Write("Enter the array size : ");
//         int arr_size = Convert.ToInt16(Console.ReadLine());
//         int []arr = new int[arr_size];
//         Console.WriteLine("Enter elements");
//         for(int i = 0;i<arr_size;i++)
//         {
//                 arr[i]= Convert.ToInt16(Console.ReadLine());
//         }
//         // int arr_size = arr.Length;
//         if (isTriplet(arr, arr_size) == true)
//             Console.WriteLine("Yes");
//         else
//             Console.WriteLine("No");
//     }
// }

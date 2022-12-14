// C# program to rotate a
// matrix by 90 degrees
using System;

class GFG {
	// An Inplace function to
	// rotate a N x N matrix
	// by 90 degrees in anti-
	// clockwise direction
	static void rotateMatrix(int N, int[, ] mat)
	{
		// Consider all
		// squares one by one
		for (int x = 0; x < N / 2; x++) {
			// Consider elements
			// in group of 4 in
			// current square
			for (int y = x; y < N - x - 1; y++) {
				// store current cell
				// in temp variable
				int temp = mat[x, y];

				// move values from
				// right to top
				mat[x, y] = mat[y, N - 1 - x];

				// move values from
				// bottom to right
				mat[y, N - 1 - x]
					= mat[N - 1 - x, N - 1 - y];

				// move values from
				// left to bottom
				mat[N - 1 - x, N - 1 - y]
					= mat[N - 1 - y, x];

				// assign temp to left
				mat[N - 1 - y, x] = temp;
			}
		}
	}

	// Function to print the matrix
	static void displayMatrix(int N, int[, ] mat)
	{
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++)
				Console.Write(" " + mat[i, j]);
			Console.WriteLine();
		}
		Console.WriteLine();
	}

	// Driver Code
	static public void Main()
	{
		int N = 4;

		// Test Case 1
		int[, ] mat = { { 1, 2, 3, 4 },
						{ 5, 6, 7, 8 },
						{ 9, 10, 11, 12 },
						{ 13, 14, 15, 16 } };

		// Test Case 2
		/* int mat[][] =
		{
			{1, 2, 3},
			{4, 5, 6},
			{7, 8, 9}
		};
		*/

		// Test Case 3
		/*int mat[][] =
		{
			{1, 2},
			{4, 5}
		};*/

		// displayMatrix(mat);

		rotateMatrix(N, mat);

		// Print rotated matrix
		displayMatrix(N, mat);
	}
}







//clockwise


// C# implementation of above approach
using System;

class GFG
{
static int N = 4;

// Function to rotate the matrix
// 90 degree clockwise
static void rotate90Clockwise(int[,] a)
{

	// Traverse each cycle
	for (int i = 0; i < N / 2; i++)
	{
		for (int j = i; j < N - i - 1; j++)
		{

			// Swap elements of each cycle
			// in clockwise direction
			int temp = a[i, j];
			a[i, j] = a[N - 1 - j, i];
			a[N - 1 - j, i] = a[N - 1 - i, N - 1 - j];
			a[N - 1 - i, N - 1 - j] = a[j, N - 1 - i];
			a[j, N - 1 - i] = temp;
		}
	}
}

// Function for print matrix
static void printMatrix(int[,] arr)
{
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)
		Console.Write( arr[i, j] + " ");
		Console.Write("\n");
	}
}

// Driver code
public static void Main ()
	{
	int [,]arr = {{1, 2, 3, 4},
				{5, 6, 7, 8},
				{9, 10, 11, 12},
				{13, 14, 15, 16}};
	rotate90Clockwise(arr);
	printMatrix(arr);
}
}

// This code is contributed
// by ChitraNayal

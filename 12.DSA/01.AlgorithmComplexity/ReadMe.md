## Data Structures, Algorithms and Complexity Homework

1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
The algorithm complexity of the provided code is **O(n<sup>2</sup>)**. The inner while loop goes through each position in the array (with complexity O(n)) at each itteration in the outer for loop. The outer loop also goes through the whole array with complexity O(n), thus the overall code complexity/running time is O(n*n) i.e O(n<sup>2</sup>).

----------

2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
The algorithm complexity of the provided code is **O(n * m)**. Assuming worst case scenario, the first loop will determine that each row starts with an even number, trigering the second loop to go through each row. In short, this means that in the worst case scenario each cell in the matrix will be visited roughly once, meaning that the code complexity is linear (proportional to the input data).

----------

3. **(*) What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
----------
The algorithm complexity of the provided code is again **O(n * m)** or in this case, since the code can only work if n = m, **O(n<sup>2</sup>)**.

In the Console.WriteLine call in the end of the code, the given row index is 0, meaning that the method starts working from the first row in the square matrix. Since the code then again visits each cell in the matrix roughly once, the complexity is linear, proportional to the input data.
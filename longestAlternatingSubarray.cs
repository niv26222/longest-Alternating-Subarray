// C# program to find the longest alternating 
// subarray in an array of N number 
using System; 
class GFG 
{ 
  
// Function to find the longest subarray 
static int longestAlternatingSubarray(int []a,  
                                      int n) 
{ 
    // Length of longest alternating 
    int longest = 1; 
    int cnt = 1; 
  
    // Iterate in the array 
    for (int i = 1; i < n; i++)  
    { 
  
        // Check for alternate 
        if (a[i] * a[i - 1] < 0) 
        { 
            cnt++; 
            longest = Math.Max(longest, cnt); 
        } 
        else
            cnt = 1; 
    } 
    return longest; 
} 
  
// Driver Code 
public static void Main() 
{ 
    int []a = { -5, -1, -1, 2, -2, -3 }; 
    int n = a.Length; 
  
    // Function to find the longest subarray 
    Console.Write(longestAlternatingSubarray(a, n)); 
} 
} 
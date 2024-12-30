using System;
using System.Collections.Generic;

namespace NSParenthesesGenerator
{
    public class Program
    {
        public static void Main() 
        {
            // This will store all the valid parentheses combinations
            var result = new List<string>();
            int n=3;
        
            // Start the recursive process with an empty string 
            // and counts of open and close parentheses as 0
            // open = 0 -> No opening parentheses used yet
            // close = 0 -> No closing parentheses used yet
            RecursiveParenthesesGenerator(result, "", 0, 0, n);
        
            // Return the list of valid combinations
            foreach (var combination in result)
            {
            	Console.WriteLine(combination);
            }
        }

        public static void RecursiveParenthesesGenerator(List<string> result, string current, int open, int close, int n)
        {
        	// Add the valid combination to the result list
        	if (current.Length == n * 2)
        	{
        		result.Add(current);
        		return;
        	}
        
        	// Recursive Case: Can we add an opening parenthesis '('?
        	// Make a recursive call with one more '(' added to the current string
        	if (open < n)
        	{
        		// Make a recursive call with one more '(' added to the current string
        		RecursiveParenthesesGenerator(result, current + "(", open + 1, close, n);
        	}
        
        	// Recursive Case: Can we add a closing parenthesis ')'?
        	// This ensures that the parentheses are balanced, i.e., every ')' matches a previously added '('
        	if (close < open)
        	{
        		RecursiveParenthesesGenerator(result, current + ")", open, close + 1, n);
        	}
        }
    }
}
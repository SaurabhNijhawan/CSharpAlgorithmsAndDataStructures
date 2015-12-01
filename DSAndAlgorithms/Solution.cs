using System;
using System.Collections.Generic;

namespace DSAndAlgorithms
{
    public class Solution
    {
        public int solution(string S)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            var stack = new Stack<string>();
            foreach (char c in S.ToCharArray())
            {
                if (char.IsDigit(c))
                {
                    stack.Push(c.ToString());
                }
                else
                {
                    if (c == '+' || c == '*')
                    {
                        try
                        {
                            var operand1 = Convert.ToInt16(stack.Pop());
                            var operand2 = Convert.ToInt16(stack.Pop());
                            if (c == '+')
                            {
                                stack.Push((operand1+operand2).ToString());
                            }
                            if (c == '*')
                            {
                                stack.Push((operand1 * operand2).ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            return -1;
                        }
                        
                    }
                }
            }

            return Convert.ToInt16(stack.Pop());
        }

      
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07BalancedParentheses
{
    public class BalancedParentheses
    {
        static void Main(string[] args)
        {
            Stack<char> parentheses = new Stack<char>();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                char parenthesis = input[i];
                switch (parenthesis)
                {
                    case '(':
                    case '{':
                    case '[':
                        parentheses.Push(parenthesis);
                        break;
                    case ')':
                        if (parentheses.Count == 0 || parentheses.Peek() != '(')
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                        else
                        {
                            parentheses.Pop();
                        }
                        break;
                    case '}':
                        if (parentheses.Count == 0 || parentheses.Peek() != '{')
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                        else
                        {
                            parentheses.Pop();
                        }
                        break;
                    case ']':
                        if (parentheses.Count == 0 || parentheses.Peek() != '[')
                        {
                            Console.WriteLine("NO");
                            Environment.Exit(0);
                        }
                        else
                        {
                            parentheses.Pop();
                        }
                        break;
                }
            }

            Console.WriteLine("YES");
        }
    }
}

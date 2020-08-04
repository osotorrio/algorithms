using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Stacks.CheckBalancedExpression
{
    public class ExpressionChecker
    {
        private readonly Stack _stack = new Stack();
        private readonly List<char> _openChars = new List<char> { '(', '{', '['};
        private readonly List<char> _closeChars = new List<char> { ')', '}', ']' };

        public bool IsBalanced(string expression)
        {
            var arr = expression.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                var item = arr[i];

                if (IsOpenChar(item))
                {
                    _stack.Push(item);
                }

                if (IsCloseChar(item))
                {
                    if (_stack.Count != 0)
                    {
                        var top = _stack.Pop();

                        if (!AreComplementary((char)top, item))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return _stack.Count == 0;
        }

        private bool AreComplementary(char open, char close)
        {
            if (open == '(')
            {
                return close == ')';
            }

            if (open == '{')
            {
                return close == '}';
            }

            if (open == '[')
            {
                return close == ']';
            }

            return false;
        }

        private bool IsOpenChar(char item)
        {
            return _openChars.Contains(item);
        }

        private bool IsCloseChar(char item)
        {
            return _closeChars.Contains(item);
        }
    }
}
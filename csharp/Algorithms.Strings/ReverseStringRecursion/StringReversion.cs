using System.Collections;

namespace Algorithms.Strings.ReverseStringRecursion
{
    public class StringReversion
    {
        public string ReverseBySwapRecursion(string input)
        {
            var array = input.ToCharArray();

            Reverse(array, 0, array.Length - 1);

            static void Reverse(char[] arr, int left, int right)
            {
                if (left < right)
                {
                    Swap(arr, left, right);
                    Reverse(arr, left + 1, right - 1);
                }
            }

            return new string(array);
        }

        public string ReverseByArrayRecursion(string input)
        {
            var array = input.ToCharArray();

            Reverse(0);

            void Reverse(int i)
            {
                if (i == array.Length) return;
                var lastItem = array[array.Length - (i + 1)];
                Reverse(i + 1);
                array[i] = lastItem;
            }

            return new string(array);
        }

        public string ReverseByStack(string input)
        {
            var arr = input.ToCharArray();

            var stack = new Stack();

            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            var counter = 0;
            while (stack.Count != 0)
            {
                var character = (char)stack.Pop();
                arr[counter] = character;
                counter++;
            }

            return new string(arr);
        }

        private static void Swap(char[] arr, int left, int right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
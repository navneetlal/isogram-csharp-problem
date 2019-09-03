using System;

namespace Isogram
{
    public class IsogramCheck
    {
        public static bool IsIsogram(string str)
        {
            bool isTrue = true;
            int[] record = new int[52];
            int start = (int)'a';
            int startA = (int)'A';
            int temp;

            // Console.WriteLine("{0}", record[4]);
            /*str = str.ToLower();*/



            foreach (char c in str)
            {
                temp = char.IsUpper(c) ? ((int)c - startA + 26) : ((int)c - start);
                if (temp < 52 && temp > 0)
                {
                    record[temp] += 1;
                }
            }


            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] > 1)
                {
                    isTrue = false;
                    break;
                }
            }
            /*Console.WriteLine("{0}", start);*/

            return isTrue;
        }

        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine($"Answer for 'hi there' {IsogramCheck.IsIsogram("hi there")}");*/
            Console.WriteLine($"{(int)' '}");
        }
    }
}

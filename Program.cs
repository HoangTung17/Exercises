using System;

namespace Exercises
{
    class Program
    {
        public void int CoutNumberOfWords() {

            int count = 0;
            int len = 1;
            string str;
            for(int i = 0; i < str.Length; i++) {
                if (str[len] == ' ' || str[len] == '\n' || str[len] == '\t')
                {
                    count++;
                }
                len++;            
            }
            return count;
        }

        public static void Main()
        {
            System.Console.WriteLine("Total number of words: {0}\n", count);  
            System.Console.ReadLine();
        }      
       
    }
}

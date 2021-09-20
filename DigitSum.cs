namespace Exercises
{
    public class DigitSum
    {
        public void int GetDigitSum() {

            int sum = 0;
            int m;
            int number = EnterNumber("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            while(number > 0) {
                m = number%10;
                sum = sum + m;
                n = n/10;
            }
        }

        public static void Main()
        {
            System.Console.WriteLine("Total number of words: {0}\n", sum);  
            System.Console.ReadLine();
        }      
    } 
}
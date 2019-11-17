using System;

namespace swapping_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swapping two numbers using a third variable
            SwappingNo1();

            // Swapping two numbers without using the third variable.
            // By using * and /
            //SwappingNo2();
            
            // Swapping two numbers without using the third variable.
            // By using + and -
            //SwappingNo3();

            //Swapping two strings without using the third variable.
            //SwappingNo4();


        }
        
        static void SwappingNo1()
        {
            
            int number1 =10, number2 = 20, temp=0;
            Console.WriteLine($"Before Swapping : number1= {number1}, number2 = {number2}");

            temp = number1; //temp = 10
            number1 = number2; //number1 = 20
            number2 = temp; //number2 = 10

            Console.WriteLine($"After Swapping : number1= {number1}, number2 = {number2}");

            Console.ReadKey();
        }

        static void SwappingNo2()
        {
            int number1 =10, number2 = 20;
            Console.WriteLine($"Before Swapping : number1= {number1}, number2 = {number2}");

            number1 = number1 * number2; //number1 = 200
            number2 = number1 / number2; //number2 = 10
            number1 = number1 / number2; //number1 = 20

            Console.WriteLine($"After Swapping : number1= {number1}, number2 = {number2}");

            Console.ReadKey();

        }

        static void SwappingNo3()
        {
            int number1 =10, number2 = 20;
            Console.WriteLine($"Before Swapping : number1= {number1}, number2 = {number2}");

            number1 = number1 + number2; //number1 = 200
            number2 = number1 - number2; //number2 = 10
            number1 = number1 - number2; //number1 = 20

            Console.WriteLine($"After Swapping : number1= {number1}, number2 = {number2}");

            Console.ReadKey();
        }

        static void SwappingNo4()
        {
            string word1 = "Swapping", word2 = "Program";
            Console.WriteLine($"Before Swapping word1= {word1}, word2 = {word2}");

            word1 = word1 + word2;
            word2 = word1.Substring(0,word1.Length - word2.Length);
            word1 = word1.Substring(word2.Length);

            Console.WriteLine($"After Swapping word1= {word1}, word2 = {word2}");

        }
    }
}

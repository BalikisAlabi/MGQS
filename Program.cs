using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*Write a program thats gets the value of two words from an input.
	        a. Get the length of each word
	       b. Add the result of the two lengths gotten from (a)
	         c. Using the ternary operator, check if the resultant value from (b) is greater than 20
		   i. If true multiply the result by 3.
		 ii. Otherwise add 20 to the result.
		
	     Example input:
		  Input one: "Country"
		  Input two: "Coding"
	
	       Example output:
		  33*/
        Console.WriteLine(".....................Question 1....................");
        Console.Write("Enter first word:");
        string firstWord = Console.ReadLine();
        int firstWordlength = firstWord.Length;

        Console.Write("Enter second word:");
        string secondWord = Console.ReadLine();
        int secondWordlength = secondWord.Length;

        int bothwordlength = firstWordlength + secondWordlength;
        int result = bothwordlength > 20 ? bothwordlength * 3 : bothwordlength + 20;
        Console.WriteLine(result);
        Console.WriteLine();

        Console.WriteLine("----------Question 2----------------");
        double sellingprice = 255.425;
        double costprice = 200.867;
        double profit = sellingprice - costprice;
        Console.WriteLine($"The selling price - costprice is : ${sellingprice - costprice}");
        Console.WriteLine($"The Profit is : ${Math.Round(profit , 2)}");
        Console.WriteLine();

        Console.WriteLine("----------Question 3---------------");
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        int index = word.IndexOf(word[2]);

        int wordLength = word.Length;
        char result = (char)newLength; 

        int newLength = index + wordLength;
        Console.WriteLine($"The third character in {word} is : {index}");
        Console.WriteLine($"The Length of the {word} is {wordLength}");

        Console.WriteLine("-----------------Question 4-----------------");
        int number1 = 10;
        int number2 = 2;
        int greaternumber = Math.Max(number1 , number2);
        Console.WriteLine($"The greater number is : {greaternumber}");
        Console.WriteLine();

        Console.WriteLine("-------------Question5----------");
        int sum = 0;
        int i = 0;
        while (i <= 4);
        {
            Console.Write("please enter number");
            string input = Console.ReadLine();
            int x;
            bool isInteger = int.Tryparse(input, out x);
            if (!isInteger)
            {
                i--;
                Console.Write("invalid inpit! ");

            }
            sum +=x;
            i++;
        }
        Console.WriteLine("$The sum of the number is :{sum}");
        Console.WriteLine();


        Console.WriteLine("-------------Question 6--------------");
        Console.WriteLine("Enter the first number:");
        double firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double secondNumber = int.Parse(Console.ReadLine());
        double result2 = firstNumber + secondNumber  -  5;
        Console.WriteLine("Enter the correct answer:");
        double correctAnswer = int.Parse(Console.ReadLine());

        if (correctAnswer == result2)
        {
            Console.WriteLine("Correct Answer!");
        }
        else
        {
            Console.WriteLine($"Wrong answer! The correct answer is :{result2}");
        }

        /*or 
        string result = (correctAnswer == result2) ? "correct Answer" : $"wrong answer! The correct answer is {result2}";*/
        Console.WriteLine();

        Console.WriteLine("---------------Question 7-------------------");
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 0 :
            Console.WriteLine("Zero");
            break;
            
            case 1 :
            Console.WriteLine("case 1");
            break;
            
            case 2 :
            Console.WriteLine("Two");
            break;
            
            case 3 :
            Console.WriteLine("Three");
            break;
            
            case 4 :
            Console.WriteLine("Four");
            break;
            
            case 5 :
            Console.WriteLine("Five");
            break;
            
            case 6 :
            Console.WriteLine("Six");
            break;
            
            case 7 :
            Console.WriteLine("Seven");
            break;
            
            case 8:
            Console.WriteLine("Eight");
            break;
            
            case 9 :
            Console.WriteLine("Nine");
            break;
            
            default :
            Console.WriteLine("Invalid input!");
            break;
        }

        


    







        
    }
}

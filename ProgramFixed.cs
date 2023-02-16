// Exercise 1

//using System;


//namespace SelectionStatementExercise
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Welcome to the number guessing game!");
//            Console.WriteLine("See if you can guess the correct number!");
//            Console.WriteLine("What is the upper limit for the range of the number");

//            var userRespone = Console.ReadLine();

//            var upperLimit = int.Parse(userRespone);


//            var random = new Random();
//            var number = random.Next(1, upperLimit);

//            int guess;
//            do
//            {



//                Console.WriteLine("Input your guess: ");

//                guess = int.Parse(Console.ReadLine());

//                if (guess > number)
//                {
//                    Console.WriteLine("Your guess is too high! Sorry");

//                }

//                else if (guess < number)

//                {
//                    Console.WriteLine("Your guess is too low! Sorry ");

//                }
//                else
//                {
//                    Console.WriteLine(" You are, Correct");

//                }

//            } while (guess != number);



//        }
//    }
//}
// Exercise 2

using System;


namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //Evaluate to a string

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "english":
                    Console.WriteLine("English is no fun!");
                    break;

                case "history":
                    Console.WriteLine("History is Cool!");
                    break;

                case "science":
                    Console.WriteLine("Science is very interesting!");
                    break;

                case "Art":
                    Console.WriteLine("Art is very Fun!");
                    break;

                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before. {subject} sounds cool!");
                    break;
            }

        }
    }
}
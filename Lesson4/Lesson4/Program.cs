using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Hello!");

             int n1;
             int n2;
             int n3;

             Console.WriteLine("Enter number 1 to 10:");
             n1 = int.Parse(Console.ReadLine());


             Console.WriteLine("Enter number 1 to 10:");
             n2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter number 1 to 10:");
             n3 = int.Parse(Console.ReadLine());

             if (n1 > n2 && n1 > n3)
             {
                 Console.WriteLine($"Kõige suurem number on: {n1}");
             }
             else if (n2 > n1 && n2 > n3)
             {
                 Console.WriteLine($"Kõige suurem number on: {n2}");
             }
             else
             {
                 Console.WriteLine($"Kõige suurem number on: {n3}");
             }
             Console.ReadLine();*/


            //Random number generator

            /*Random randomGenerator = new Random();
            int userNumber;
            int randomNumber = randomGenerator.Next(1, 7);  //esimene arv sisse arvatud ja teine alates välja arvatud

            Console.WriteLine("Enter number 1 to 6: ");
            userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(randomNumber);

            if (userNumber > randomNumber)
            {
                //int newVar
                Console.WriteLine("You win!");
            }

            else if (userNumber < randomNumber)
            {
                Console.WriteLine("You lost! Try again!");
            }

            else
            {
                Console.WriteLine("Tie!");
            }*/

            /*int userRoll;
            int cpuRoll;
            int rolls = 0;
            int userScore = 0;
            int cpuScore = 0;

            Random rnd = new Random();

            while(rolls < 3)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);

                Console.WriteLine($"You rolled {userRoll}, CPU rolled {cpuRoll}");

                if(userRoll > cpuRoll)
                {
                    //userScore = userScore + 1;
                    userScore++;
                }
                else if(userRoll < cpuRoll)
                {
                    cpuScore++;
                }
                else
                {
                    continue;
                }

                rolls++;
                Console.ReadLine();


            }

            if(userScore > cpuScore)
            {
                Console.WriteLine("Congratulation! You won!");
            }
            else if(userScore < cpuScore)
            {
                Console.WriteLine("You lost! Try again.");
            }
            else
            {
                Console.WriteLine("Tie. Nobody wins or loses.");
            }
            Console.WriteLine($"You scored {userScore}, CPU scored {cpuScore}!");*/



            /*Random rnd = new Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine($"CPU generated {randomNumber}");

            switch(randomNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                 case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("CPU generated nothing.");
                    break;

            }*/

            Console.WriteLine("Pick a color (red, black, blue): ");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "red":
                    Console.WriteLine("You are a romantic type.");
                    break;
                case "black":
                    Console.WriteLine("You are a loner.");
                    break;
                case "blue":
                    Console.WriteLine("You are in love with the sea");
                    break;
                default:
                    Console.WriteLine("Cannot recognize the color.");
                    break;
            }


            Console.ReadLine();






        }
    }
}

using System;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please insert the number you want to check: "); // ask client to insert the number
                int theNumber = Convert.ToInt32(Console.ReadLine()); // read the number, convert it to integer and put it in "theNumber"

                if (theNumber < 2) // check if the number is less than 2, so it's not a prime number
                {
                    Console.WriteLine("the number you inserted is {0}, and it's not a prime number", theNumber);

                }
                if (theNumber == 2 || theNumber == 3) // check if the number is 2 or 3, so the number is a prime number
                {
                    Console.WriteLine("{0} is a Prime number...");
                }

                else
                {
                    int tester = 0; // this
                    int divisibleNumber = theNumber;
                    for (int i = 2; i < theNumber; i++)
                    {
                        if (theNumber % i == 0)
                        {
                            tester++; // an integer to test if the number is divisible or not
                            divisibleNumber = i; // an integer that the number is divisible to it
                            break;
                        }
                    }
                    if (tester > 0)
                    {
                        Console.WriteLine("{0} is not a prime number, it is divisible to {1}", theNumber, divisibleNumber);
                    }
                    else
                    {
                        Console.WriteLine("{0} is a Prime number...", theNumber);
                    }

                }
                Console.WriteLine("do you want to continue with another number? [y/n]");
                ConsoleKeyInfo result = Console.ReadKey();
               
                if ((result.KeyChar == 'N') || (result.KeyChar == 'n')) // ask if the client wants to continue or not
                {
                    break;
                }
                Console.Clear(); 
            }

            


        }
    }
}

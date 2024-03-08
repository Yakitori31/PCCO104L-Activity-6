using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the activity number (1-5) or 'exit' to quit:");
            string activityInput = Console.ReadLine();

            if (activityInput.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            if (int.TryParse(activityInput, out int activityNumber))
            {
                switch (activityNumber)
                {
                    case 1:
                        RunMoneyDenominationActivity();
                        break;
                    case 2:
                        RunNumberDivisibilityActivity();
                        break;
                    case 3:
                        RunInputMessageActivity();
                        break;
                    case 4:
                        RunBuildPyramidActivity();
                        break;
                    case 5:
                        RunSumVsAppendActivity();
                        break;
                    default:
                        Console.WriteLine("Activity does not exist. Please enter a valid activity number (1-5).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid activity number (1-5) or 'exit'.");
            }
        }
    }

    static void RunMoneyDenominationActivity()
    {
        Console.Write("Enter the denomination: ");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal bills))
        {
            switch (bills)
            {
                case 0.01m:
                case 0.05m:
                case 0.25m:
                    Console.WriteLine("No Person is Found");
                    break;
                case 1:
                    Console.WriteLine("Jose Rizal");
                    break;
                case 5:
                    Console.WriteLine("Emilio Aguinaldo");
                    break;
                case 10:
                    Console.WriteLine("Andres Bonifacio, Apolinario Mabini");
                    break;
                case 20:
                    Console.WriteLine("Manuel L. Quezon");
                    break;
                case 50:
                    Console.WriteLine("Sergio Osmena");
                    break;
                case 100:
                    Console.WriteLine("Manuel Roxas");
                    break;
                case 200:
                    Console.WriteLine("Diosdado Macapagal");
                    break;
                case 500:
                    Console.WriteLine("Benigno Sr. and Corazon Aquino");
                    break;
                case 1000:
                    Console.WriteLine("Jose Abad Santos, Vicent Lim, Josefa Llanes Escoda");
                    break;
                default:
                    Console.WriteLine($"Invalid Denomination: {bills}");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        }
    }

    static void RunNumberDivisibilityActivity()
    {
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FooBar");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    static void RunInputMessageActivity()
    {
        Console.WriteLine("Enter text. Type 'exit' to exit.");

        string input = Console.ReadLine();

        while (input != "exit")
        {
            Console.WriteLine("You entered: " + input);
            input = Console.ReadLine();
        }

        Console.WriteLine("Program closed.");
    }

    static void RunBuildPyramidActivity()
    {
        int n;

        do
        {
            Console.Write("Enter a non-negative number 0 to exit the program: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
                continue;
            }

            if (n == 0)
            {
                Console.WriteLine("Exiting the program.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i * 2 - 1).PadLeft(n + i));
            }

        } while (true);
    }

    static void RunSumVsAppendActivity()
    {
        int sum = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program..");
                break;
            }

            if (int.TryParse(userInput, out int number))
            {
                sum += number;
                Console.WriteLine($"Adding {number} to {sum} = {sum}");
            }
            else
            {
                message += userInput;
                Console.WriteLine($"Current Message is: {message}");
            }
        }
    }
}
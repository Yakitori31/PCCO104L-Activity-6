using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Choose a program (1-5) or type exit to close the program");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "exit")
    {
      Console.WriteLine("Closing program.");
      break;
    }
    
    if (int.TryParse(userInput, out int programNumber)) && programNumber >= 1 && programNumber <= 5)
    {
      RunProgram(programNumber);
    }
      
    else
    {
      Console.WriteLine("Invalid input. Please enter a number between 1 and 5 or type exit to close the program.");
    }  
  }
}

static void RunProgram(int programNumber)
{
  switch (programNumber)
  {
  case 1:
    Program1();
    break;
  case 2:
    Program2();
    break;
  case 3:
    Program3();
    break;
  case 4:
    Program4();
    break;
  case 5:
    Program5();
    break;
  }
}

static void Program1()
{
Console.
}

}
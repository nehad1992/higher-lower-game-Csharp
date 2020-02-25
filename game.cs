using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    FirstChoice();
  }

  public static void FirstChoice()
  {
    Console.WriteLine("Do you want to play the lower or higher game");
    Console.WriteLine("Type Y (if answer is yes) or N (if answer no)");
    string yesOrNo = Console.ReadLine().ToLower();
    if(yesOrNo == "y")
    {
      Game();
    } 
    else if (yesOrNo == "n")
    {
      Console.WriteLine("Goodbye then!");
    }
    else
    {
    Console.WriteLine("I'm sorry. I don't understand you");
    FirstChoice();
    }
  }

  public static void Game()
  {
    Console.WriteLine("Guess a random number");
    Random random = new Random();
    // Generate initial random number

    int randomOne = random.Next(1,100);
    Console.WriteLine("Is you number higher or lower than " + randomOne);
    Console.WriteLine("Please, response 'higher', 'lower' or 'correct'");
    string answerOne = Console.ReadLine();

    int randomTwo = FirstRandom(answerOne, randomOne);
    Console.WriteLine("Is you number higher or lower than " + randomTwo);
    string answerTwo = Console.ReadLine();

    int randomThree = NextRandom(answerTwo, answerOne, randomTwo, randomOne);
    Console.WriteLine("Is you number higher or lower than " + randomThree);
    string answerThree = Console.ReadLine();

    int randomFour = NextRandom(answerThree, answerTwo, randomThree, randomTwo);
    Console.WriteLine("Is you number higher or lower than " + randomFour);

  }

  public static int FirstRandom(string answer, int number){
    Random random = new Random();
    int randomNumber = 0;
    if(answer == "lower")
    {
      randomNumber = random.Next(1,number);
    } 
    else if (answer == "higher")
    {
      randomNumber = random.Next(number,100);
    }
    return(randomNumber);
  }

  public static int NextRandom(string answer, string answerPrev, int number, int previous){
    Random random = new Random();
    int randomNumber = 0;
    if(answerPrev == "lower"){
      if(answer == "lower")
      {
        randomNumber = random.Next(1,number);
      } 
      else if (answer == "higher")
      {
        randomNumber = random.Next(number, previous);
      }
    } else if (answerPrev == "higher")
    {
      if(answer == "lower")
      {
        randomNumber = random.Next(previous, number);
      } 
      else if (answer == "higher")
      {
        randomNumber = random.Next(number, 100);
      }
    }

    return(randomNumber);
  }

}
  





  //   public static void Main()
  // {
  //   string answer = "";
  //   Console.WriteLine("Do you want to play the lower or higher game?(yes/no)");
  //   string yesOrNo = Console.ReadLine();
  //   if(yesOrNo == "yes"){

  //   }
  //   Console.WriteLine("Guess a random number");
  //   Random random = new Random();
  //   // Generate initial random number
  //   int randomOne = random.Next(1,100);
  //   Console.WriteLine("Is you number higher or lower than " +randomOne);
  //   // Take lower/higher from user
  //   string answerOne = Console.ReadLine();
  // // Check if initial random number is higher or lower
  //   while(answerOne.Length>0){
  //     if(answerOne == "lower"){
  //       int randomTwo = random.Next(1,randomOne);
  //       Console.WriteLine(randomTwo);
  //     } else if (answerOne == "higher"){
  //       int randomTwo = random.Next(randomOne,100);
  //       Console.WriteLine(randomTwo);
  //     }
  //     else if(answerOne == "correct"){
  //     Console.WriteLine("Program quits");
  //     break;
  //   }
  // }
  // }


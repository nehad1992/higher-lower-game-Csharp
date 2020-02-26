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

    int randomTwo = SecondRandom(answerOne, randomOne);
    Console.WriteLine("Is you number higher or lower than " + randomTwo);
    string answerTwo = Console.ReadLine();


//////////////////////////////////
    string response = answerTwo;
    string previousResponse = answerOne;
    int currentRandom = randomTwo;
    int previousRandom = randomOne;

    while (response != "correct")
    {
      previousRandom = currentRandom;
      currentRandom = NextRandom(response, previousResponse, currentRandom, previousRandom);
      Console.WriteLine("Is you number higher or lower than " + currentRandom);
      previousResponse = response;
      response = Console.ReadLine();
    }
 ///////////////////////////////////   
    Console.WriteLine ("You number is" + currentRandom);
  }



    // int randomThree = NextRandom(answerTwo, answerOne, randomTwo, randomOne);
    // Console.WriteLine("Is you number higher or lower than " + randomThree);
    // string answerThree = Console.ReadLine();

    // int randomFour = NextRandom(answerThree, answerTwo, randomThree, randomTwo);
    // Console.WriteLine("Is you number higher or lower than " + randomFour);
    // string answerFour = Console.ReadLine();

    // int randomFive = NextRandom(answerFour, answerThree, randomFour, randomThree);
    // Console.WriteLine("Is you number higher or lower than " + randomFive);

    // string answerFive = Console.ReadLine();

    // int randomSix= NextRandom(answerFive, answerFour, randomFive, randomFour);
    // Console.WriteLine("Is you number higher or lower than " + randomSix);


// ---------------------
// string response = "";
// // string previousResponse = "";
// int random = 50;
// int previousRandom = 

// while (response != "correct")
// {
//   random = NextRandom(currResponse, previousResponse, randomNumber, previousRandom);
//   Console.WriteLine("Is you number higher or lower than " + random);
//   previousResponse = currResponse;
//   response = Console.ReadLine();


// }

// Console.Writeline ("You number is" + random);

// ---------------------


  public static int SecondRandom(string answer, int number){
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
    Console.WriteLine(randomNumber);
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
  





//     public static void Main()
//   {
//     string answer = "";
//     Console.WriteLine("Do you want to play the lower or higher game?(yes/no)");
//     string yesOrNo = Console.ReadLine();
//     if(yesOrNo == "yes"){
//       Console.WriteLine("Guess a random number");
//       Random random = new Random();
//     // Generate initial random number
//       int randomOne = random.Next(1,100);
//       Console.WriteLine("Is you number higher or lower than " +randomOne);
//     // Take lower/higher from user
//       string answerOne = Console.ReadLine();
//   // Check if initial random number is higher or lower
//       while(answerOne.Length>0){
//         if(answerOne == "lower"){
//         int randomTwo = random.Next(1,randomOne);
//         Console.WriteLine("Is ")
//         Console.WriteLine(randomTwo);
//         } else if (answerOne == "higher"){
//         int randomTwo = random.Next(randomOne,100);
//         Console.WriteLine(randomTwo);
//         }
//         else if(answerOne == "correct"){
//         Console.WriteLine("Program quits");
//         break;
//         }
//       } 
//     }
//   } 
// }

//  bool gameOver = false;
//     int randomNumber = 50;
//     int lowNumber = 0;
//     int highNumber = 100;

//     while(gameOver == false)
//     {
//       Console.WriteLine("Is you number higher or lower than " + randomGuess + " ?");
//       Console.WriteLine("Please, response 'higher', 'lower' or 'correct'");
//       string userAnswer = Console.ReadLine();
//       if(userAnswer != "correct")
//       {
//         gameOver = true;
//       }
//       else if(userAnswer != "higher")
//       {
//         break;
//       }
//       else if(userAnswer != "lower")
//       {
//         break;
//       }
//       else
//       {
//         Console.WriteLine("Error: I can't help you. No one can.");
//       }
//     }
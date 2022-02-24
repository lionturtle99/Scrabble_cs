using System.Collections.Generic;
using System.Linq;
using System;
using ScrabbleGame.Models;

namespace ScrabbleGame
{
  public class Program
  {
    public static void Main()
    {
      bool playGame = true;
      
      while (playGame == true)
      {
        Console.WriteLine("Please enter a word Player 1");
        string player1 = Console.ReadLine();
        Console.WriteLine("Please enter a word Player 2");
        string player2 = Console.ReadLine();

        Scrabble scrabble = new Scrabble();
        int score1 = 0;
        score1 += scrabble.ScrabbleLetters(player1);
        int score2 = 0;
        score2 += scrabble.ScrabbleLetters(player2);

        if (score1 > 20)
        {
          Console.WriteLine("Player 1 wins with "+score1+" points");
          playGame = false;
        }
        else if(score2 > 20)
        {
          Console.WriteLine("Player 2 wins with "+score2+" points");
          playGame = false;
        }

        if (score1 > score2)
        {
          Console.WriteLine("Nicely done player 1!");
          Console.WriteLine("Player 1 score: "+score1);
        } 
        else if (score2 > score1)
        {
          Console.WriteLine("Nicely done player 2!");
          Console.WriteLine("Player 2 score: "+score2);
        }
        else
        {
          Console.WriteLine("IT WAS A DRAW!!! PLEASE PLAY AGAIN");
        }
      }
    }
  }
}
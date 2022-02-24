using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ScrabbleGame.Models
{
  public class Scrabble
  {
    public int ScrabbleLetters(string input)
    {
      char[] ls = input.ToLower().ToCharArray();

      char[] onePoint = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      char[] twoPoint = {'d','g'};
      char[] threePoint = {'b','c','m','p'};
      char[] fourPoint = {'f', 'h', 'v', 'w', 'y'};
      char[] fivePoint = {'k'};
      char[] eightPoint = {'j', 'x'};
      char[] tenPoint = {'q', 'z'};

      int points = 0;

      foreach (char l in ls)
      {
        foreach (char a in onePoint)
        {
          if (l == a)
          {
            points += 1;
          }
        }
        foreach (char d in twoPoint)
        {
          if (l == d)
          {
            points += 2;
          }
        }
        foreach (char b in threePoint)
        {
          if (l == b)
          {
            points += 3;
          }
        }
        foreach (char f in fourPoint)
        {
          if (l == f)
          {
            points += 4;
          }
        }
        foreach (char k in fivePoint)
        {
          if (l == k)
          {
            points += 5;
          }
        }
        foreach (char j in eightPoint)
        {
          if (l == j)
          {
            points += 8;
          }
        }
        foreach (char q in tenPoint)
        {
          if (l == q)
          {
            points += 10;
          }
        }
      }
      return points;
    }
  }
}
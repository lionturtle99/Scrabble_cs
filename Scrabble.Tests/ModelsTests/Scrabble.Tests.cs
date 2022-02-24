using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleGame.Models;
using System;

namespace ScrabbleGame.Tests
{
  [TestClass]
  public class Scrabble
  {
    [TestMethod]
    public void Scrabble_CreateInstanceOfScrabble_Scrabble()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(typeof(Scrabble), scrabble.GetType());
    }
    
  }
}
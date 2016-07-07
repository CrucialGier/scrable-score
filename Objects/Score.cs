using System;
using Nancy;
using Xunit;
using System.Collections.Generic;

namespace Scrabble.Objects
{
  public class Score
  {
    private char _wordInput;
    private static string _letterScore1 = "aeioulnrst";
    private static string _letterScore2 = "dg";
    private static string _letterScore3 = "bcmp";
    private static string _letterScore4 = "fhvwy";
    private static string _letterScore5 = "k";
    private static string _letterScore8 = "jx";
    private static string _letterScore10 = "qz";
    private static string[] _allLettersArray = {_letterScore1, _letterScore2, _letterScore3, _letterScore4, _letterScore5, _letterScore8, _letterScore10};
    private int _letterScore = 0;

    public char GetLetterInput()
    {
      return _wordInput;
    }
    public void SetLetterInput(char newLetterInput)
    {
      _wordInput = newLetterInput;
    }

    public int GetScore()
    {
      foreach (string letterGroup in _allLettersArray)
      {
        foreach (char letter in letterGroup)
        {
          if (letter == _wordInput)
          {
            if (letterGroup == _letterScore1)
            {
              return _letterScore += 1;
            }
            else if (letterGroup == _letterScore2)
            {
              return _letterScore += 2;
            }
            else if (letterGroup == _letterScore3)
            {
              return _letterScore += 3;
            }
            else if (letterGroup == _letterScore4)
            {
              return _letterScore += 4;
            }
            else if (letterGroup == _letterScore5)
            {
              return _letterScore += 5;
            }
            else if (letterGroup == _letterScore8)
            {
              return _letterScore += 8;
            }
            else
            {
              return _letterScore += 10;
            }
          }
        }
      }
      return _letterScore;
    }
    
  }
}

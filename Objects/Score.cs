using System;
using Nancy;
using Xunit;
using System.Collections.Generic;

namespace Scrabble.Objects
{
  public class Score
  {
    private string _wordInput;
    private static string _letterScore1 = "aeioulnrst";
    private static string _letterScore2 = "dg";
    private static string _letterScore3 = "bcmp";
    private static string _letterScore4 = "fhvwy";
    private static string _letterScore5 = "k";
    private static string _letterScore8 = "jx";
    private static string _letterScore10 = "qz";
    private static int[] _scores = {1,2,3,4,5,8,10};
    private static string[] _allLettersArray = {_letterScore1, _letterScore2, _letterScore3, _letterScore4, _letterScore5, _letterScore8, _letterScore10};
    private int _letterScore = 0;
    public string GetLetterInput()
    {
      return _wordInput;
    }
    public void SetLetterInput(string newLetterInput)
    {
      _wordInput = newLetterInput;
    }
    public int GetScore()
    {
      foreach (char tile in _wordInput)
      {
        for (int i = 0; i < _allLettersArray.Length; i ++)
        {
          foreach (char letter in _allLettersArray[i])
          {
            if (letter == tile)
            {
              return _letterScore += _scores[i];
            }
          }
        }
      }
      return _letterScore;
    }
  }
}

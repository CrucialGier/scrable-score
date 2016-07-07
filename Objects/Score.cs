using Nancy;
using Xunit;
using System.Collections.Generic;

namespace Scrabble.Objects
{
  public class Score
  {
    private char _letterInput;
    // private string[] _letterScore1 = ["a","e","i","o","u","l","n","r","s","t"];
    private string _letterScore1 = "aeioulnrst";
    public int _letterScore = 0;

    public char GetLetterInput()
    {
      return _letterInput;
    }
    public void SetLetterInput(char newLetterInput)
    {
      _letterInput = newLetterInput;
    }

    public int GetScore()
    {
      foreach (char letter in _letterScore1)
      {
        if (letter == _letterInput)
        {
          return _letterScore += 1;
        }
      }
      return _letterScore;
    }
  }
}



// for (int i = 0; i < _letterScore1.Length; i++)
// {
//   if (_letterScore1.charAt(i) == _letterInput)
//   {
//     return _letterScore += 1;
//   }
// }

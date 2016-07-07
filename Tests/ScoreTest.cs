using Xunit;

namespace Scrabble.Objects
{
  public class ScoreTest
  {
    [Fact]
    public void GetScore_SingleLetterScore_1()
    {
      Score newScoreTest = new Score ();
      Assert.Equal(1, newScoreTest.GetScore());
      // Score.SetLetterInput('l');
      // Score.GetScore();
      // Assert.Equal(1, _letterScore);
    }
  }
}

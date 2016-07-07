using Xunit;

namespace Scrabble.Objects
{
  public class ScoreTest
  {
    [Fact]
    public void GetScore_SingleLetterScore_1()
    {
      Score newScoreTest = new Score ();
      newScoreTest.SetLetterInput("l");
      Assert.Equal(1, newScoreTest.GetScore());
    }
  }
}

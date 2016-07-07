using Xunit;

namespace Scrabble.Objects
{
  public class ScoreTest
  {
    [Fact]
    public void GetScore_SingleLetterScore_true()
    {
      Score newScoreTest = new Score ();
      //Make all variables & methods static to avoid creating a new object
      newScoreTest.SetLetterInput("l");
      Assert.Equal(1, newScoreTest.GetScore());
    }
    [Fact]
    public void GetScore_WholeWordScore_false()
    {
      Score newScoreTest = new Score ();
      newScoreTest.SetLetterInput("adbfkjq");
      Assert.Equal(1, newScoreTest.GetScore());
    }
  }
}

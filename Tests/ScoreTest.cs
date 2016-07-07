using Xunit;

namespace Scrabble.Objects
{
  public class ScoreTest
  {
    [Fact]
    public void GetScore_SingleLetterScore_1()
    {
      Score newScoreTest = new Score ();
      //Make all variables & methods static to avoid creating a new object
      newScoreTest.SetLetterInput('l');
      Assert.Equal(1, newScoreTest.GetScore());
    }
  }
}

using Nancy;
using Scrabble.Objects;
using System.Collections.Generic;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/new_word"] = _ => {
        Score newScore = new Score ();
        newScore.SetLetterInput(Request.Form["new-word"]);
        return View["index.cshtml", newScore.GetScore()];
      };
    }
  }
}

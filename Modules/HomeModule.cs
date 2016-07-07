using System;
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
        string input = Request.Form["new-word"];
        char singleInput = Convert.ToChar(input);
        newScore.SetLetterInput(singleInput);
        return View["index.cshtml", newScore.GetScore()];
      };
    }
  }
}

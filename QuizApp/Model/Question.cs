﻿using System.Collections.Generic;
using System.Linq;
using QuizApp.View.Interface;

namespace QuizApp.Model
{
  public class Question
  {
    public int Number { get; set; }

    public int RepetitionNumber { get; set; }

    public string Name { get; set; }

    public bool HasOneAnswer { get; set; }

    public List<Answer> Answers { get; set; }

    public bool IsAnsweredCorrectly(IQuizView view)
    {
      if (view.CheckedAnswer1 != Answers[0].IsCorrect)
      {
        return false;
      }

      if (view.CheckedAnswer2 != Answers[1].IsCorrect)
      {
        return false;
      }

      if (view.CheckedAnswer3 != Answers[2].IsCorrect)
      {
        return false;
      }

      if (view.CheckedAnswer4 != Answers[3].IsCorrect)
      {
        return false;
      }

      if (view.CheckedAnswer5 != Answers[4].IsCorrect)
      {
        return false;
      }

      return true;
    }
  }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using QuizManager.Model.Interface;

namespace QuizManager.Model
{
  public class QuizModel : IQuizModel
  {
    private const int DefaultRepetitionNumber = 1;
    private bool _shuffleAnswers;
    private bool _hideAnswerLetter;
    private int _repetitionNumber;
    private string _textFromResource;

    public QuizModel(
      bool shuffleAnswers, 
      bool hideAnswerLetter, 
      string repetitionNumberText, 
      string textFromResource)
    {
      _shuffleAnswers = shuffleAnswers;
      _hideAnswerLetter = hideAnswerLetter;
      _repetitionNumber = ConvertRepetitionNumberText(repetitionNumberText);
      _textFromResource = textFromResource;     
    }

    public bool ShuffleAnswers
    {
      get { return _shuffleAnswers; }
      set { _shuffleAnswers = value; }
    }

    public bool HideAnswerLetter
    {
      get { return _hideAnswerLetter; }
      set { _hideAnswerLetter = value; }
    }

    public int RepetitionNumber
    {
      get { return _repetitionNumber; }
      set { _repetitionNumber = value; }
    }

    public string TextFromResource
    {
      get { return _textFromResource; }
      set { _textFromResource = value; }
    }


    public List<Question> Questions { get; set; }

    public bool IsAllAnswered()
    {
      return Questions.All(x => x.RepetitionNumber <= 0);
    }

    public int ConvertRepetitionNumberText(string repetitionNumberText)
    {
      int repetitionNumber = DefaultRepetitionNumber;
      if (!string.IsNullOrWhiteSpace(repetitionNumberText))
      {
        repetitionNumber = Convert.ToInt32(repetitionNumberText);
      }

      return repetitionNumber;
    }
  }
}

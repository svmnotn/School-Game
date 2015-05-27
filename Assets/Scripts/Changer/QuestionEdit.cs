namespace Shadow.SchoolGame.Changer {
  using Utils;
  using Loaders;
  using Game.Data;
  using System.IO;
  using UnityEngine;
  using UnityEngine.UI;
  using System.Collections.Generic;
  
  public class QuestionEdit : MonoBehaviour {
    public QuestionData data;
    public ScrollContentFitter content;
    public InputField question;
    public InputField image;

    void OnEnable() {
      if(Loader.currentQuestion == null) {
        Loader.currentQuestion = new QuestionData();
        Loader.currentQuestion.answers = new List<AnswerData>();
        Loader.currentQuestion.value = Loader.currentValue;
      }
      data = Loader.currentQuestion;
      question.text = data.question ?? "";
      image.text = data.image ?? "";
      foreach(AnswerData a in data.answers) {
        var ae = content.ReturnAddedContent().GetComponent<AnswerEdit>();
        ae.data = a;
        ae.answer.text = a.answer ?? "";
        ae.correct.isOn = a.correct;
        ae.image.text = a.image ?? "";
      }
    }

    public void QuestionChange(string q) {
      data.question = q;
    }

    public void ImageChange(string i) {
      data.image = i;
      if(File.Exists(Extensions.LocalizeInTopic(Loader.currentTopic, data.image))) {
        image.textComponent.color = Color.green;
        data.spr = Extensions.LoadSprite(Extensions.LocalizeInTopic(Loader.currentTopic, data.image));
      } else {
        image.textComponent.color = Color.red;
      }
    }

    public void AddAnswer() {
      AnswerData d = new AnswerData();
      content.ReturnAddedContent().GetComponent<AnswerEdit>().data = d;
      data.answers.Add(d);
    }

    public void RemoveAnswer() {
      data.answers.RemoveAt(data.answers.Count - 1);
      content.RemoveLastContent();
    }

    void OnDisable() {
      content.Clear();
      data = null;
    }

    public void Save() {
      if(!Loader.currentTopic.HasQuestion(Loader.currentValue, Loader.currentQuestion)) {
        Loader.currentTopic.AddQuestion(Loader.currentValue, Loader.currentQuestion.Copy(Loader.currentTopic));
      }
      QuestionLoader.SaveQuestion();
      Loader.currentQuestion = null;
    }
  }
}
namespace SchoolGame.Data {
  using System.Collections.Generic;

  public class Topic {
    public string name;
    public IDictionary<int, Question> questions;
  }
}
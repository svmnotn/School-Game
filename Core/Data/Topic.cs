namespace SchoolGame.Data {
  using Questions = System.Collections.Generic.IDictionary<int, Question>;

  public class Topic {
    public string name;
    public Questions questions;
  }
}
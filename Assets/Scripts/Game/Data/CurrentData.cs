namespace Shadow.SchoolGame.Game.Data {
  using Utils;

  public class CurrentData {
    [System.NonSerialized]
    public GameMode mode;
    public bool blue = true;
    public int blueScore;
    public int redScore;
    public TopicData currentTopic;
    public int currentValue;
    public QuestionData currentQuestion;
    public bool answered;
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGame {
  using Answers = IList<Answer>;
  public class Question {
    public int value;
    public string question;
    public string imageLoc;
    [NonSerialized]
    public string loc;
    public Answers answers;
  }
}
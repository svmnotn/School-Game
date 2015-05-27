namespace Shadow.SchoolGame.Game.Buttons {
  using UnityEngine;
  using UnityEngine.UI;

  public class ResolutionButton : MonoBehaviour {
    public ResolutionController control;
    public Resolution r;
    public int index;
    Image img;
    Color def;

    void Start() {
      GetComponentInChildren<Text>().text = control.GenerateFullResolutionString(r);
      GetComponent<Button>().interactable = control.IsAllowedResolution(r);
      img = GetComponent<Image>();
      def = img.color;
    }

    void Update() {
      if(control.IsCurrentResolution(r)) {
        Color c = img.color;
        c.g = 255;
        c.r = 0;
        c.b = 0;
        img.color = c;
      } else {
        img.color = def;
      }
    }
  
    public void Click() {
      control.TryChangeResolution(index);
    }
  }
}
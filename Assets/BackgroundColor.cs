namespace Shadow.SchoolGame {
  using UnityEngine;

  public class BackgroundColor : MonoBehaviour {
    public Camera cam;

    void Update() {
      Color c = new Color();
      c.a = 1;
      c.r = Utils.Settings.settings.backgroundColorR;
      c.g = Utils.Settings.settings.backgroundColorG;
      c.b = Utils.Settings.settings.backgroundColorB;
      cam.backgroundColor = c;
    }
  }
}
namespace Shadow.SchoolGame.Game.Controllers {
  using Utils;
  using Buttons;
  using UnityEngine;

  public class ResolutionControl : MonoBehaviour {
    public ScrollContentFitter fitter;
    public ResolutionController controller;

    void OnEnable() {
      for(int i = 0; i < controller.SortedResolutions.Length; i++) {
        var bttn = fitter.ReturnAddedContent().GetComponent<ResolutionButton>();
        bttn.control = controller;
        bttn.r = controller.SortedResolutions[i];
        bttn.index = i;
      }
    }

    void OnDisable() {
      fitter.Clear();
    }
  }
}
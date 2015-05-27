namespace Shadow.SchoolGame.Game.Buttons {
  using UnityEngine;

  public class ToggleButton : MonoBehaviour {
    public GameObject toggle;

    public void OnClick(){
      toggle.SetActive(!toggle.activeInHierarchy);
    }
  }
}
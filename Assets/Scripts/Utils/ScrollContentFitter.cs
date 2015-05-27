namespace Shadow.SchoolGame.Utils {
  using UnityEngine;
  using UnityEngine.UI;

  public class ScrollContentFitter : MonoBehaviour {
    public RectTransform.Axis axis = RectTransform.Axis.Vertical;
    public RectTransform content;
    public LayoutElement element;
    public float offset;

    public void AddContent(LayoutElement element = null) {
      ReturnAddedContent(element);
    }

    public LayoutElement ReturnAddedContent(LayoutElement element = null) {
      content.SetSizeWithCurrentAnchors(axis, GetRect() + offset);
      LayoutElement elem = Instantiate(element ?? this.element);
      elem.transform.SetParent(content);
      elem.transform.localPosition = new Vector3(0, 0, 0);
      elem.transform.localScale = new Vector3(1, 1, 1);
      content.SetSizeWithCurrentAnchors(axis, GetRect() + GetMin(elem));
      return elem;
    }

    public void RemoveContent(LayoutElement element) {
      content.SetSizeWithCurrentAnchors(axis, GetRect() - offset);
      content.SetSizeWithCurrentAnchors(axis, GetRect() - GetMin(element));
      DestroyImmediate(element.gameObject);
    }

    public void RemoveLastContent() {
      Transform last = content.transform.GetChild(content.transform.childCount - 1);
      RemoveContent(last.gameObject.GetComponent<LayoutElement>());
    }

    public void Clear() {
      while(content.transform.childCount > 0) {
        RemoveLastContent();
      }
    }

    float GetRect() {
      if(axis == RectTransform.Axis.Vertical) {
        return content.rect.height;
      }
      if(axis == RectTransform.Axis.Horizontal) {
        return content.rect.width;
      }
      return 0;
    }

    float GetMin(LayoutElement element) {
      if(axis == RectTransform.Axis.Vertical) {
        return element.minHeight;
      }
      if(axis == RectTransform.Axis.Horizontal) {
        return element.minWidth;
      }
      return 0;
    }
  }
}
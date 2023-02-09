using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDescription;
    [SerializeField] private Image cursor;
    [SerializeField] private Image cursorOnPainting;

    // Start is called before the first frame update
    void Start()
    {
        MouseCursorInit();
    }

    private void OnMouseDown()
    {
        DescriptionSwitch();
    }
    private void OnMouseEnter()
    {
        MouseCursorSwitch();
    }

    private void OnMouseExit()
    {
        MouseCursorSwitch();
    }

    public void MouseCursorInit()
    {
        cursor.enabled = true;
        cursorOnPainting.enabled = false;
    }

    public void MouseCursorSwitch()
    {
        cursor.enabled = !cursor.enabled;
        cursorOnPainting.enabled = !cursorOnPainting.enabled;
    }

    public void DescriptionSwitch()
    {
        textDescription.enabled = !textDescription.isActiveAndEnabled;
    }
}

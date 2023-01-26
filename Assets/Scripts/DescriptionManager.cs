using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.UI;

public class DescriptionManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDescription;
    [SerializeField] private Image cursor;
    [SerializeField] private Image cursorOnPainting;

    // Start is called before the first frame update
    void Start()
    {
        cursor.enabled = true;
        cursorOnPainting.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        textDescription.enabled = !textDescription.isActiveAndEnabled;
    }
    private void OnMouseEnter()
    {
        cursor.enabled = false;
        cursorOnPainting.enabled = true;
    }

    private void OnMouseExit()
    {
        cursor.enabled = true;
        cursorOnPainting.enabled = false;
    }
}

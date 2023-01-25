using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class DescriptionManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDescription;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        textDescription.enabled = !textDescription.isActiveAndEnabled;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saber : MonoBehaviour
{
    public LayerMask layer;
    public LayerMask otherLayer;
    private Vector3 previousPos;

    public AudioClip impact;   
    public AudioSource audioSource;

    bool noReturn=true;
    Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        RaycastHit hit;
       // Debug.DrawRay(transform.position, Vector3.forward, Color.green);




        if (Physics.Raycast(transform.position, transform.forward,out hit,1.5f, otherLayer))
        {
            m_Collider = hit.collider;
            m_Collider.enabled = false;
        }


        if (Physics.Raycast(transform.position, transform.forward,out hit,1.5f,layer))
        {
           

            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) < 130)
            {
                m_Collider = hit.collider;
                m_Collider.enabled = false;

                
                //var desactiveSlice = hit.transform.gameObject.GetComponent<Sliceable>();
               // desactiveSlice.enabled = false;

            }

                else if (Vector3.Angle(transform.position-previousPos,hit.transform.up)>130)
            {
                audioSource.PlayOneShot(impact, 0.7F);
               // Destroy(hit.transform.gameObject);
            }
           
        }
        previousPos = transform.position;
        
    }
} 
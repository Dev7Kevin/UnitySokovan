using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;
    
    public Color touchColor;
    private Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // OnCollisionEnter(Collision other)
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            myRenderer.material.color = originalColor;
        }
    }

    void OnTriggerStay(Collider other)
    {
        myRenderer.material.color = touchColor;
    }
}

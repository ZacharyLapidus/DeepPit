using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropaway : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        {
            Debug.Log("hotfire");
            transform.Translate(0f, -2.6f, 0f);
        }
    }
    void OnTriggerExit(Collider other)
    {
        {
            Debug.Log("coldfire");
            transform.Translate(0f, 2.6f, 0f);
        }
    }
}

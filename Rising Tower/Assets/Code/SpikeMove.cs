using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour
{
    private Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("Move");
            transform.Translate(0f, 1.5f, 0f);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("Move");
            transform.Translate(0f, -1.5f, 0f);
        }
    }
}

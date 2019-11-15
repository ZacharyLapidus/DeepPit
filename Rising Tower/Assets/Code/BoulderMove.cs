using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderMove : MonoBehaviour
{
    private Vector3 startPos;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("roll");
           transform.position = startPos;
            rb.isKinematic = false;
        }
    }
    /*void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("roll");
            transform.position = startPos;
        }
    }*/
}

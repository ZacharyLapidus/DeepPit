using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RealCharacterPopup : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;
    public float xdown = 0f;
    public float ydown = 0f;
    public float zdown = 0f;

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
        if (other.tag == ("Player"))
        {
            Debug.Log("I found you faker!");
            transform.Translate(x, y, z);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("You're not even good enough to be my fake");
            transform.Translate(xdown, ydown, zdown);
        }
    }
}

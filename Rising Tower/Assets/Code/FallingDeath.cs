using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDeath : MonoBehaviour
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
        if (other.tag == ("Player"))
        {
            Debug.Log("Deathup");
            transform.Translate(0f, 20.6f, 0f);
        }
    }
}

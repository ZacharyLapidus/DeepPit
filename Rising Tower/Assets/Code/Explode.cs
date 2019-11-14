using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    ParticleSystem butts;
    // Start is called before the first frame update
    void Start()
    {
        butts = GetComponent<ParticleSystem>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        {
            Debug.Log("Explode");
            butts.Play();
        }
    }
}

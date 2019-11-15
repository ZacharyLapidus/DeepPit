using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private Vector3 startPos;
    public float xAngle, yAngle, Zangle;
    public float wait;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dropper()
    {
        yield return new WaitForSeconds(wait);
        transform.position = new Vector3(-90f, 0f, 0f);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("Drop");
            StartCoroutine(Dropper());
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(3f);
        transform.position = startPos;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            StartCoroutine(Reset());
            Debug.Log("Reseting");
            
        }
    }
}

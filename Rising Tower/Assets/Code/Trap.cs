using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float xAngle, yAngle, Zanglel
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*IEnumerator Dropper()
    {
        WaitForSeconds(1.5);
        transform.position = new Vector3(0f, 0f, 0f);
        
    }*/
    void OnTriggerEnter(Collider other)
    {
        {
            Debug.Log("Drop");
            //StartCoroutine(Dropper));
            //transform.localScale += new Vector3(x, y, z);
        }
    }

    /*void OnTriggerExit(Collider other)
    {
        {
            Debug.Log("Move");
            transform.localScale -= new Vector3(x, y, z);
        }
    }*/
}

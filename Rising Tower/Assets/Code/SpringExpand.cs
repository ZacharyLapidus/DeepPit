using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringExpand : MonoBehaviour
{
    private Vector3 startPos;
    public float x = 0f;
    public float y = .5f;
    public float z = 0f;
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
        {
            Debug.Log("Move");
            transform.localScale += new Vector3(x, y, z);
        }
    }
    void OnTriggerExit(Collider other)
    {
        {
            Debug.Log("Move");
            transform.localScale -= new Vector3(x, y, z);
        }
    }
}

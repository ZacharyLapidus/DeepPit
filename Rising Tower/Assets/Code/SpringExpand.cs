using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringExpand : MonoBehaviour
{
    private Vector3 startPos;
    public float x = 0f;
    public float y = .5f;
    public float z = 0f;
    private AudioSource m_boioing;
    private AudioClip boioing;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        m_boioing = GetComponent<AudioSource>();
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
            PlayBoioing();
            
        }
    }
    private void PlayBoioing()
    {
        m_boioing.clip = boioing;
        m_boioing.Play();
    }

    void OnTriggerExit(Collider other)
    {
        {
            Debug.Log("Move");
            transform.localScale -= new Vector3(x, y, z);
        }
    }
}

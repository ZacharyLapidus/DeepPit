using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTeleport : MonoBehaviour
{
    public Transform teleportTarget;

    public GameObject thePlayer;

    

    void OnTriggerEnter(Collider other)
    {
       
        //thePlayer.transform.position = teleportTarget.transform.position;
        if (other.tag == ("DeathTag"))
        {
            Debug.Log("Restart!");
            thePlayer.transform.position = teleportTarget.transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
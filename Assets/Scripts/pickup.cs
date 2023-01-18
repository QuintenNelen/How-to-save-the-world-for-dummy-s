using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource.Play(); //play pickup sound
            Destroy(gameObject);
            
            followingLevel.points += 1; //get a point 
            Debug.Log(followingLevel.points);
        }

    }
}

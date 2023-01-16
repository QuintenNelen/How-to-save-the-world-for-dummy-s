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
            audioSource.Play();
            Destroy(gameObject);
            
            followingLevel.points += 1;
            Debug.Log(followingLevel.points);
        }

    }
}

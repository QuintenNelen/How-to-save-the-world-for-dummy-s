using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{

    [SerializeField]
    AudioSource pickupSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickupSound.enabled = true;
            Destroy(gameObject);
            
            followingLevel.points += 1;
            Debug.Log(followingLevel.points);
        }
        else
        {
            pickupSound.enabled = false;
        }
    }
}

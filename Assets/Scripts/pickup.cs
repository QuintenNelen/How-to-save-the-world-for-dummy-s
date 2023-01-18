using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{
<<<<<<< HEAD

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            nextLevel.pickedUp = true;
            followingLevel.points += 1;
        }
=======
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

>>>>>>> 86854edd2d0f1e03e7e610f70784ef4ac0d05e31
    }
}

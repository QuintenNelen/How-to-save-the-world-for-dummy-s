using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Item soundtrack van player collect sound + score optellen 

public class collectseed : MonoBehaviour
{
    public AudioSource collectSound;
   
  void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        
        followingLevel.points += 1;
        Debug.Log(followingLevel.points);
        keepscore.Thescore += 1;
        Destroy(gameObject);

        
    }
}

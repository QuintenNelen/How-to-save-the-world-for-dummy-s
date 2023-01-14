using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectseed : MonoBehaviour
{
    public AudioSource collectSound;
    // Start is called before the first frame update
  void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        keepscore.Thescore += 1;
        Destroy(gameObject);

        
    }
}

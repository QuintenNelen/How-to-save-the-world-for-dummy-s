using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingMusic : MonoBehaviour
{
    [SerializeField]
    AudioSource footsteps;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)  )
        {
            footsteps.enabled = true; //when keys are pressed music plays
        }
        else
        {
            footsteps.enabled = false;
        }
    }
}

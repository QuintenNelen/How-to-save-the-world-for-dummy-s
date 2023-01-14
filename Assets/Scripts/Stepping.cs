using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stepping : MonoBehaviour
{
    [SerializeField]
    AudioSource stepping;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            stepping.enabled = true;
        } 
        else
        {

            stepping.enabled = false;

        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class followingLevel : MonoBehaviour
{
   
    static public int points=0;
    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player" && points == 4 )
        {
            Debug.Log("Collid");
            SceneManager.LoadScene("Level4"); //on collision and enough points load next level
        }
    }
}

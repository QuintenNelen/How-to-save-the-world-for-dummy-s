using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class followingLevel : MonoBehaviour
{
   
    static public int points=0;
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && points == 5)
        {
            SceneManager.LoadScene("Level4"); //on collision and enough points load next level
        }
    }
}

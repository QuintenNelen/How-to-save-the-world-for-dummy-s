using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class followingLevel : MonoBehaviour
{
   
    static public int points=0;
    // Update is called once per frame
<<<<<<< HEAD
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && points == 5)
        {
=======
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player" && points == 4 )
        {
            Debug.Log("Collid");
>>>>>>> 86854edd2d0f1e03e7e610f70784ef4ac0d05e31
            SceneManager.LoadScene("Level4"); //on collision and enough points load next level
        }
    }
}

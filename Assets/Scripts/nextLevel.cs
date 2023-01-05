using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    static public bool pickedUp = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && pickedUp == true) 
        {
            Debug.Log("Level2");
            SceneManager.LoadScene("Level2");
        }
    }
}

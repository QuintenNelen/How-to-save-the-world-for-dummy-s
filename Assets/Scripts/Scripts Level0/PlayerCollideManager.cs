using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollideManager : MonoBehaviour
{
    [SerializeField] GameOverManager gameOverManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Road")
        {
            Debug.Log("Game Over");

            gameOverManager.SetGameOver();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    Scene cScene;
    string sceneName;
    private void Start()
    {
        cScene = SceneManager.GetActiveScene();
        sceneName = cScene.name;    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (sceneName)
            {
                case "Level1":
                    SceneManager.LoadScene("Level2");
                    break;
                case "Level2":
                    SceneManager.LoadScene("Level3");
                    break;
                case "Level3":
                    SceneManager.LoadScene("Level4");
                    break;
                case "Level4":
                    SceneManager.LoadScene("Level5");
                    break;
                case "Level5":
                    SceneManager.LoadScene("Endscreen");
                    break;
            }
            
        }
    }
}

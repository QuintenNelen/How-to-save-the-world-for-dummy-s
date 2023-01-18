using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class followingLevel : MonoBehaviour
{
    Scene cScene;
    string sceneName;
    private void Start()
    {
        cScene = SceneManager.GetActiveScene();
        sceneName = cScene.name;
    }

    static public int points=0;
    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player" && points >= 4 )
        {
            Debug.Log("Collid");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    public void StartGame()
    {
        //start de game vanuit de UI
        SceneManager.LoadScene("Level1");
    }
}

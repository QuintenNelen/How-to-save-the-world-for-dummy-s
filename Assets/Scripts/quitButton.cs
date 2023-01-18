using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitButton : MonoBehaviour
{
    public void QuitGame()
    {
        //sluit de applicatie af
        Debug.Log("Quit");
        Application.Quit();
    }
}

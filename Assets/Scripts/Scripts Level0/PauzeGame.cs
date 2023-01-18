using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeGame : MonoBehaviour
{
    [SerializeField] GameObject gamePauze;

    void Update()
    {
        if (Input.GetKey(KeyCode.P)) // for now this will be key p in unity 
        {
            gamePauze.SetActive(true); //if esc key is pressed show this UI
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    public void ContinueGame()
    {
        gamePauze.SetActive(false); //Turns UI off again and you can continue playing the game
        //Debug.Log("continue");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void QuitGameInPauze()
    {
        Application.Quit(); // quits the game
        Debug.Log("Quit");
    }
}

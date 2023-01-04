using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oke : MonoBehaviour
{
    [SerializeField] private string promt;
    [SerializeField] GameOverManager gameOverManager;
    public string InteractionPromt => promt;

    public bool Interact(Interactor interactor)
    {
        //Debug.Log("plant!");
        gameOverManager.SetGameOver();
        return true;
    }
}

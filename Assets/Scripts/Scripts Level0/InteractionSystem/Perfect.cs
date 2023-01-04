using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perfect : MonoBehaviour, Iinteractible
{
    [SerializeField] private string promt;
    [SerializeField] GameOverManager gameOverManager;
    public string InteractionPromt => promt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Opening chest!");
        gameOverManager.SetGameOver();
        return true;
    }
}

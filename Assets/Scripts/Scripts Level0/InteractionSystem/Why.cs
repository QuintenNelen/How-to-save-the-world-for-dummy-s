using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Why : MonoBehaviour, Iinteractible
{
    [SerializeField] private string promt;
    [SerializeField] GameOverManager gameOverManager;
    public string InteractionPromt => promt;

    public bool Interact(Interactor interactor)
    {
        gameOverManager.SetGameOver();
        return true;
    }
}

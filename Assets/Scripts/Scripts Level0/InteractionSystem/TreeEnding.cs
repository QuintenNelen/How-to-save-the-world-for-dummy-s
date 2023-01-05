using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeEnding : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOverManager;

    public void ShowEnding()
    {
        gameOverManager.SetGameOver();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//score board visueel score laten zien via textmeshpro

public class keepscore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public  static int Thescore;

    void Update()
    {
        scoreText.text = "Score: " + Thescore;

        
    }


   
}

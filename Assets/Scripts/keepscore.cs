using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class keepscore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public  static int Thescore;

    void Update()
    {
        scoreText.text = "Score: " + Thescore;

        
    }

    /*void update(){
        Thescore += 1;
        scoreText.text = "Score: " + Thescore;
    }*/

   
}

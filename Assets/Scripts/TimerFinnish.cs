using System.Collections;
using UnityEngine;

public class TimerFinnish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        GameObject.Find("Player").SendMessage("Finnish");
    }
}

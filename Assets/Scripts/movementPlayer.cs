using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPlayer : MonoBehaviour
{
    //script dat zorgt dat de speler kan wandelen
    public float speed = 0.1f;
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0.0f, 0f, speed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    //script dat zorgt dat de pick-up wordt verwijderd bij een trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            nextLevel.pickedUp = true; //zet de status van een variable op "true" zodat we naar het volgende level kunnen. als deze variable "false" is, kan er niet naar het volgende level gegaan worden
        }
    }
}

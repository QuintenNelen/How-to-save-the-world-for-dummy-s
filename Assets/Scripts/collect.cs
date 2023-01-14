using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//items op pikken en vernietig  
public class collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            nextLevel.pickedUp = true;
        }
    }
}

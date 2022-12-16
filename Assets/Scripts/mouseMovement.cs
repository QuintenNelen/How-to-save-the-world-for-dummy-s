using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMovement : MonoBehaviour
{
    public float mouseSens;
    public Transform player;
    float rotX = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSens;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSens;
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotX, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}

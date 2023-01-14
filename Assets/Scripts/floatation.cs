using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatation : MonoBehaviour
{
    //Inspiratiebron: http://www.donovankeith.com/2016/05/making-objects-float-up-down-in-unity/
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    void Start()
    {
        posOffset = transform.position;
    }
    void Update()
    {
        //"animatie" voor het hoveren van de pick-up
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}

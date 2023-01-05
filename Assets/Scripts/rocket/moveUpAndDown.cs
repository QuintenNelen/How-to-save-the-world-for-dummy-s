using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpAndDown : MonoBehaviour
{

    public float speed = 5f;
    public float height = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float newY = Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(pos.x, newY, pos.z) * height;
    }
}

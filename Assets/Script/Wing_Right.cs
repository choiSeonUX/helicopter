using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing_Right : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        
    }
    void Update()
    {
        float InputKey = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left * speed * InputKey);
    }
}

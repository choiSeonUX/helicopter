using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    Wing_Left wing_left;
    Wing_Right wing_right;
    Tail_Wing_Left tail_left;
    Tail_Wing_Right tail_right;


    public float speed = 5f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        wing_left = GetComponent<Wing_Left>(); 
        wing_right = GetComponent<Wing_Right>();
        tail_left = GetComponent<Tail_Wing_Left>();
        tail_right = GetComponent<Tail_Wing_Right>(); 
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float ySpeed = yInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, ySpeed, 0f);

       

        playerRigidbody.velocity = newVelocity;
    }


}

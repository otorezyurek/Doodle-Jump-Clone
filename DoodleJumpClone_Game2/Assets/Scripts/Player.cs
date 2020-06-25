using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;    // hareket hızı

    Rigidbody2D rb;    // objenin RigidBody2D bileşenine referans

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    // RigidBody2D referansını al
    }

    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");    // sağ-sol inputu

        rb.velocity = new Vector2(input * speed, rb.velocity.y);    //inputa göre hareket
    }
}

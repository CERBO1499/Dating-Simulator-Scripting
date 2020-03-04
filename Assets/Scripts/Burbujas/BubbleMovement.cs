using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BubbleMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    protected static float Target;


    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.down*speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PaddleController))]
[RequireComponent(typeof(Rigidbody2D))]
public class Bot : MonoBehaviour
{
    public float precision = 0.5f;
    public Rigidbody2D ball;

    private PaddleController _controller;
    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _controller = GetComponent<PaddleController>();
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float distance = ball.position.y - _rigidBody.position.y;
        if (distance > precision)
        {
            _controller.Up();
        }
        else if (distance < -precision)
        {
            _controller.Down();
        }
    }
}

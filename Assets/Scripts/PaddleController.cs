using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PaddleController : MonoBehaviour, IPaddleController
{
    public float speed = 2.5f;
    public BoxCollider2D bottomBoundary;
    public BoxCollider2D topBoundary;

    private Rigidbody2D _rigidBody;

    private void Start() => _rigidBody = GetComponent<Rigidbody2D>();

    public bool CanGoDown() => !_rigidBody.IsTouching(bottomBoundary);

    public bool CanGoUp() => !_rigidBody.IsTouching(topBoundary);

    public void Down()
    {
        if (!CanGoDown())
        {
            return;
        }
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }

    public void Up()
    {
        if (!CanGoUp())
        {
            return;
        }
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}

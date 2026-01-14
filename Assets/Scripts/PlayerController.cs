using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPaddleController
{
    public int Speed = 1;

    public Transform Position;
    public Rigidbody2D HitBox;
    public BoxCollider2D BottomBoundary;
    public BoxCollider2D TopBoundary;

    public bool CanGoDown() => !HitBox.IsTouching(BottomBoundary);
    public bool CanGoUp() => !HitBox.IsTouching(TopBoundary);
    public void Down()
    {
        if (!CanGoDown())
        {
            return;
        }
        Position.Translate(0, -Speed * Time.deltaTime, 0);
    }
    public void Up()
    {
        if (!CanGoUp())
        {
            return;
        }
        Position.Translate(0, Speed * Time.deltaTime, 0);
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Up();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Down();
        }
    }
}

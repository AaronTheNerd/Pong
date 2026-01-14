using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public float precision = 0.5f;
    public PaddleController controller;
    public Rigidbody2D self;
    public Rigidbody2D ball;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float distance = ball.position.y - self.position.y;
        if (distance > precision)
        {
            controller.Up();
        }
        else if (distance < -precision)
        {
            controller.Down();
        }
    }
}

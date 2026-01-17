using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum BallState
{
    IDLE,
    MOVING
}

[RequireComponent(typeof(Rigidbody2D))]
public class BallMove : MonoBehaviour
{
    public float speed = 5.0f;
    public float idleSeconds = 0.5f;
    public float bounceAcceleration = 1.1f;

    private Rigidbody2D _rigidBody;
    private BallState _state;
    private float _startTime;

    private void Start()
    {
        _state = BallState.IDLE;
        _startTime = Time.timeSinceLevelLoad;
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_state == BallState.IDLE)
        {
            HandleIdle();
        }
    }

    private void HandleIdle()
    {
        if (Time.timeSinceLevelLoad - _startTime >= idleSeconds)
        {
            BeginMoving();
        }
    }

    private void BeginMoving()
    {
        _state = BallState.MOVING;
        _rigidBody.velocity = transform.rotation * Vector3.up * speed;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        float dist = transform.position.y - GameObject.Find("Player1").transform.position.y;
        print(dist);
    }
}

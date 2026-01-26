using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

internal enum EBallState
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
    private EBallState _state;
    private float _startTime;
    private Vector2 _direction;

    private void Start()
    {
        _state = EBallState.IDLE;
        _startTime = Time.timeSinceLevelLoad;
        _rigidBody = GetComponent<Rigidbody2D>();
        _direction = StartingDirection();
    }

    private void Update()
    {
        if (_state == EBallState.IDLE)
        {
            HandleIdle();
        }
    }

    private void FixedUpdate()
    {
        if (_state == EBallState.MOVING)
        {
            _rigidBody.velocity = _direction * speed;
        }
    }

    private Vector2 StartingDirection()
    {
        float angle = Random.Range(45f, 135f);
        return Quaternion.Euler(0, 0, angle) * Vector2.up;
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
        _state = EBallState.MOVING;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            _direction.y *= -1;
        }
        else if (collision.gameObject.CompareTag("Paddle"))
        {
            _direction.x *= -1;
        }
        speed *= bounceAcceleration;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        float dist = transform.position.y - GameObject.Find("Player1").transform.position.y;
        print(dist);
    }
}

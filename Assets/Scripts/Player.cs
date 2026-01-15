using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PaddleController))]
public class Player : MonoBehaviour
{
    private PaddleController _controller;

    private void Start() => _controller = GetComponent<PaddleController>();

    private void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _controller.Down();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _controller.Up();
        }
    }
}

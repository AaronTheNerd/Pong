using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IPaddleController))]
public class Player : MonoBehaviour
{
    private IPaddleController _controller;

    private void Start() => _controller = GetComponent<IPaddleController>();

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

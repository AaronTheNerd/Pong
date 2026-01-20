using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Canvas))]
public class Pausemenu : MonoBehaviour
{
    private Canvas _canvasObject;

    private void Start()
    {
        _canvasObject = GetComponent<Canvas>();
        _canvasObject.enabled = false;

    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _canvasObject.enabled = !_canvasObject.enabled;
            Time.timeScale = _canvasObject.enabled? 0:1;
        }
    }
}

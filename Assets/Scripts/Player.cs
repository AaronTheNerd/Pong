using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PaddleController Controller;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Controller.Down();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Controller.Up();
        }
    }
}

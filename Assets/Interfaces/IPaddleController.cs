using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPaddleController
{
    public void Up();
    public void Down();
    public bool CanGoUp();
    public bool CanGoDown();
}

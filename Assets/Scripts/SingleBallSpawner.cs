using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour, IBallSpawner
{
    public GameObject ballPrefab;

    private void Start()
    {
        SpawnBall();
    }

    public GameObject SpawnBall()
    {
        return Instantiate(ballPrefab);
    }
}

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
        float angle = Random.Range(45f, 135f);
        Quaternion quaternion = Quaternion.Euler(0, 0, angle);
        return Instantiate(ballPrefab, Vector3.zero, quaternion);
    }
}

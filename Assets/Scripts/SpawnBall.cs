using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ball;

    public void Spawn()
    {
        GameObject.Instantiate(Ball, this.gameObject.transform);
    }
}

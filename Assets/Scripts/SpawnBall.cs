using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ball;

    private void OnEnable()
    {
        AtBatManager.AtBatDone += SpawnResult;
    }
    public void SpawnResult(AtBatResult atBat)
    {        
        GameObject.Instantiate(Ball, this.gameObject.transform);  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtBatManager : MonoBehaviour
{
    [SerializeField]
    private float _cooldownTime = 1f;

    private Batter _batterUp;
    private float _timeSinceLastSpawn;

    public delegate void AtBatSimulated(AtBatResult atBat);
    public static event AtBatSimulated AtBatDone;

    private void Awake()
    {
        _batterUp = GameObject.FindGameObjectWithTag("Player").GetComponent<Batter>();
    }
    private void Start()
    {
        _timeSinceLastSpawn = _cooldownTime;
    }
    private void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;
    }
    public void SimulateAtBat()
    {
        if (_timeSinceLastSpawn >= _cooldownTime)
        {
            AtBatResult atBatRes = new AtBatResult();
            atBatRes = _batterUp.SimulateAtBat();
            AtBatDone(atBatRes);
            _timeSinceLastSpawn = 0f;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter : MonoBehaviour
{
    public BatterStats Stats;

    private float _walkPercent = 0f;
    private float _singlePercent = 0f;
    private float _doublePercent = 0f;
    private float _triplePercent = 0f;
    private float _homerunPercent = 0f;
    private float _strikeoutPercent = 0f;
    private float _hitoutPercent = 0f;

    private void Start()
    {
        LoadPlayerStats();
    }

    private void LoadPlayerStats()
    {
        _walkPercent = Stats.Walks / Stats.AtBats * 100 ;
        _singlePercent = (Stats.Singles / Stats.AtBats) * 100 + _walkPercent;
        _doublePercent = (Stats.Doubles / Stats.AtBats) * 100 + _singlePercent;
        _triplePercent = (Stats.Triples / Stats.AtBats) * 100 + _doublePercent;
        _homerunPercent = (Stats.Homeruns / Stats.AtBats) * 100 + _triplePercent;
        _strikeoutPercent = (Stats.StrikeOuts / Stats.AtBats) * 100 + _homerunPercent;
        _hitoutPercent = (Stats.HitOut / Stats.AtBats) * 100 + _strikeoutPercent;
    }

    public void SimulateAtBat()
    {
        float randNum = UnityEngine.Random.Range(1f, 100f);

        if (randNum <= _walkPercent)
        {
            Debug.Log("Walk");
        }
        else if (randNum <= _singlePercent) 
        {
            Debug.Log("Single");
        }
        else if (randNum <= _doublePercent)
        {
            Debug.Log("Double");
        }
        else if (randNum <= _triplePercent)
        {
            Debug.Log("Triple");
        }
        else if (randNum <= _homerunPercent)
        {
            Debug.Log("HomeRun");
        }
        else if (randNum <= _strikeoutPercent)
        {
            Debug.Log("Strike Out");
        }
        else if (randNum <= _hitoutPercent)
        {
            float flyOrGround = UnityEngine.Random.Range(1, 3);
            if (flyOrGround == 1)
            {
                Debug.Log("Fly Out");
            }
            else
            {
                Debug.Log("Ground Out");
            }
        }

    }
}

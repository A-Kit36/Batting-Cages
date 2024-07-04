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

    public AtBatResult SimulateAtBat()
    {
        float randNum = UnityEngine.Random.Range(1f, 100f);
        AtBatResult atBat = new AtBatResult();

        if (randNum <= _walkPercent)
        {
            //Debug.Log("Walk");
            atBat = AtBatResult.Walk;
        }
        else if (randNum <= _singlePercent) 
        {
            //Debug.Log("Single");
            atBat = AtBatResult.Single;
        }
        else if (randNum <= _doublePercent)
        {
            //Debug.Log("Double");
            atBat = AtBatResult.Double;
        }
        else if (randNum <= _triplePercent)
        {
           /* Debug.Log("Triple");*/
            atBat = AtBatResult.Tripple;
        }
        else if (randNum <= _homerunPercent)
        {
            //Debug.Log("HomeRun");
            atBat = AtBatResult.Homerun;
        }
        else if (randNum <= _strikeoutPercent)
        {
            //Debug.Log("Strike Out");
            atBat = AtBatResult.Strikeout;
        }
        else if (randNum <= _hitoutPercent)
        {
            float flyOrGround = UnityEngine.Random.Range(1, 3);
            if (flyOrGround == 1)
            {
                //Debug.Log("Fly Out");
                atBat = AtBatResult.Flyout;
            }
            else
            {
                //Debug.Log("Ground Out");
                atBat = AtBatResult.Groundout;
            }
        }

        return atBat;

    }
}

public enum AtBatResult
{
    Walk,
    Single,
    Double,
    Tripple,
    Homerun,
    Strikeout,
    Flyout,
    Groundout
}

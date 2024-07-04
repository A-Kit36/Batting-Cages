using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _atBatResultText;

    private void OnEnable()
    {
        AtBatManager.AtBatDone += UpdateAtBatResult;
    }

    private void OnDisable()
    {
        AtBatManager.AtBatDone -= UpdateAtBatResult;
    }

    private void UpdateAtBatResult(AtBatResult atBat)
    {
        _atBatResultText.text = atBat.ToString();
    }
}

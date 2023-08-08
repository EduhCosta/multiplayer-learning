using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPlayerStats : MonoBehaviour
{
    [SerializeField] private TMP_Text countText;

    private void OnEnable()
    {
        PlayerLength.ChangeLengthEvent += ChangeLengthText;
    }

    private void OnDisable()
    {
        PlayerLength.ChangeLengthEvent -= ChangeLengthText;
    }

    private void ChangeLengthText(ushort obj)
    {
        countText.text = obj.ToString();
    }
}

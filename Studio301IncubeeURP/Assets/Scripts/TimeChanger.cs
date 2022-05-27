using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Unity.VisualScripting;

public class TimeChanger : MonoBehaviour
{
    [Header("Time change settings")]
    [HideInInspector] public bool night;
    [SerializeField] private Light mainLight;
    [SerializeField] private float firstValueIntensity;
    [SerializeField] private float secondValueIntensity;
    [SerializeField] private float timeChangeDuration;
    private void Start()
    {
        DOTween.Init();
    }

    public void ChangeTime()
    {
        switch (night)
        {
            case true:
                mainLight.DOIntensity(firstValueIntensity, timeChangeDuration);
                night = false;
                break;
            case false:
                mainLight.DOIntensity(secondValueIntensity, timeChangeDuration);
                night = true;
                break;
        }
        
    }

}

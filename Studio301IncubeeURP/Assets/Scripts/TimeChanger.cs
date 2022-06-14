using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Unity.VisualScripting;

public class TimeChanger : MonoBehaviour
{
    [Header("Time change settings")]
    public bool night;
    [SerializeField] private Light mainLight;
    [SerializeField] private float firstValueIntensity;
    [SerializeField] private float secondValueIntensity;
    [SerializeField] private float timeChangeDuration;

    private float lightTemperature;

    private void Start()
    {
        DOTween.Init();
    }

    public void ChangeTime()
    {
        switch (night)
        {
            case false:
                mainLight.DOIntensity(firstValueIntensity, timeChangeDuration);
                night = true;
                DOTween.To(()=> mainLight.colorTemperature, x=> mainLight.colorTemperature = x, 20000, timeChangeDuration);
                break;
            case true:
                mainLight.DOIntensity(secondValueIntensity, timeChangeDuration);
                DOTween.To(()=> mainLight.colorTemperature, x=> mainLight.colorTemperature = x, 6500, timeChangeDuration);
                night = false;
                break;
        }
        
    }
    
    

}

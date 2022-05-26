using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    public bool night;
    [SerializeField] private Light mainLight;
    public void ChangeTime()
    {
        switch (night)
        {
            case true:
                mainLight.intensity = 1;
                night = false;
                break;
            case false:
                mainLight.intensity = 0;
                night = true;
                break;
        }
    }
}

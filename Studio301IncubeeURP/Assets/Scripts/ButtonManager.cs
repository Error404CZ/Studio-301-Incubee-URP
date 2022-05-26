using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public TimeChanger timeChanger;
    public void ChangeTimeClick()
    {
        timeChanger.ChangeTime();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class IronGateController : MonoBehaviour
{
    [Header("Iron Gate settings")]
    [SerializeField] private GameObject ironGate;
    [SerializeField] private Transform transform1;
    [SerializeField] private Transform transform2;
    [SerializeField] private float timeToChange;
    private void Start()
    {
        DOTween.Init();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "IronGate")
        {
            ironGate.transform.DOMove(transform2.position,timeToChange);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "IronGate")
        {
            ironGate.transform.DOMove(transform1.position, timeToChange);
            
        }
    }
}
    

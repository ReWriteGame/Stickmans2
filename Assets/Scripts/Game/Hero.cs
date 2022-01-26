using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    [SerializeField] private StateStickman currentState;
    public UnityEvent takeRightItemEvent;
    public UnityEvent takeWrongItemEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<StateStickman>())
        {
            if (currentState.CurrentMaterial == other.gameObject.GetComponent<StateStickman>().CurrentMaterial)
            {
                takeRightItemEvent?.Invoke();
            }
            else
            {
                takeWrongItemEvent?.Invoke();
            }
        }
    }
}

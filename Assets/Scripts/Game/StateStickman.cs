using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateStickman : MonoBehaviour
{
    [SerializeField] private Material currentMaterial;
    
    private MeshRenderer meshRenderer;
    
    public Material CurrentMaterial => currentMaterial;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SetterStateStickman>())
        {
            currentMaterial = other.gameObject.GetComponent<SetterStateStickman>().CurrentMaterial;
            ApplyState();
        }
    }

    public void ApplyState()
    {
        if (currentMaterial != null)
            meshRenderer.material = currentMaterial;
    }

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
        ApplyState();
    }
}

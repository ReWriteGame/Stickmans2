using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SetterStateStickman : MonoBehaviour
{
   [SerializeField] private Material currentMaterial;
   public Material CurrentMaterial => currentMaterial;
}

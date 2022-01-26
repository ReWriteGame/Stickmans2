using System;
using UnityEngine;

public class SizeSetter : MonoBehaviour
{
   [SerializeField] private float sizePerOneUnit = 0.1f;
   [SerializeField] private ScoreCounter score;

   private Vector3 startScale;

   private void Awake()
   {
      startScale = transform.localScale;
   }

   private void OnEnable()
   {
      score.changeScoreEvent.AddListener(ChangeSize);
   }
   private void OnDisable()
   {
      score.changeScoreEvent.RemoveListener(ChangeSize);
   }

   public void ChangeSize()
   {
      transform.localScale = startScale + Vector3.one * score.Score * sizePerOneUnit;
   }
}

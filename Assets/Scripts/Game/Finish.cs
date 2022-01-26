using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
   [SerializeField] private int sizeForWin = 5;
   
   public UnityEvent loseGameEvent;
   public UnityEvent winGameEvent;

   private void OnTriggerEnter(Collider other)
   {
      if(other.gameObject.GetComponent<Hero>())
          if (other.gameObject.GetComponentInChildren<ScoreCounter>().Score >= sizeForWin)
          {
              winGameEvent?.Invoke();
          }
          else
          {
              loseGameEvent?.Invoke();
          }
   }
}

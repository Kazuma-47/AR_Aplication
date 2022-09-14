using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearTimer : MonoBehaviour
{
  private float timer;
  
  public void DisapearOnTimer(float time)
  {
    timer = time;
  }

  private void Update()
  {
    timer -= Time.deltaTime;
    if (timer <= 0f)
    {
      gameObject.SetActive(false);
    }
    
            
  }
}

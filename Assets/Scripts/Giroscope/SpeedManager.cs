using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] private UnityEvent <string> onCollision = new UnityEvent<string>();
    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.transform.tag;
        if(tag == "ramp") onCollision?.Invoke(tag);
        else if(tag == "rampup") onCollision?.Invoke(tag); 
        else onCollision?.Invoke("nonRamp");
    }
}

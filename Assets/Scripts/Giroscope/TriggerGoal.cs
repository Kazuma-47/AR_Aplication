using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGoal : MonoBehaviour
{
    private Commincation _server;
    private void OnTriggerEnter(Collider other)
    {
        string Tag = other.transform.tag;
        if (Tag == "Player")
        {
            _server = GameObject.Find("DontDestroy").GetComponent<Commincation>();
            _server.SendMsg("Finished BallGame");  
        }
    }
}

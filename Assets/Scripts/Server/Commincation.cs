using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MClient;

public class Commincation : MonoBehaviour
{
    // Start is called before the first frame update
    private Client _serverCLient;
    void Start()
    {
        _serverCLient = new Client("ws://192.168.137.1:8080", "Game");
        
    }

    public void SendMsg(string keyCode)
    {
        _serverCLient.Send(new Message("Console", keyCode));  
    }
}

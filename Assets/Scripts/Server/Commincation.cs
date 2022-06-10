using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MClient;

public class Commincation : MonoBehaviour
{
    // Start is called before the first frame update
    private Client _serverCLient;
    [SerializeField] private string serverIP;
    static private bool _connected;
    void Start()
    {
        if (_connected != true)
        {
            _serverCLient = new Client(serverIP, "Game");
            _connected = true;
        }

        
    }

    public void SendMsg(string keyCode)
    {
        _serverCLient.Send(new Message("Console", keyCode));  
    }
}

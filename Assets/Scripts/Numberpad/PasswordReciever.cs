using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using MClient;

public class PasswordReciever : MonoBehaviour
{ 
    [SerializeField] private int[] _currentSequence = new int[4];
    //private Client Bob;


    /*void Start()
    {
        Bob = new Client("ws://192.168.137.1:8080", "joao");
        
    }*/
    public void AddNumberToPassword(int number)
    {
        for (int i = 0; i < _currentSequence.Length; i++)
        {
            if (_currentSequence[i] != 0) continue;
                _currentSequence[i] = number;
                GetComponent<DisplayHandeler>().UpdateUi(string.Join(" ", _currentSequence));
                break;
        }
    }

    /*public void OnSubmit()
    {
        Bob.Send(new Message("Console", string.Join("", _currentSequence)));  
    }*/
    public void ResetPassword()
    {
        Array.Clear(_currentSequence, 0, _currentSequence.Length);
        GetComponent<DisplayHandeler>().UpdateUi(string.Join(" ", _currentSequence));
    }
    
}

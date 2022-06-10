using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using MClient;

public class PasswordReciever : MonoBehaviour
{
    public string CorrectPassword;
    [SerializeField] private string serverIP;
    [SerializeField] private int[] _currentSequence = new int[4];
    private Commincation Bob;


    
    public void AddNumberToPassword(int number)
    {
        for (int i = 0; i < _currentSequence.Length; i++)
        {
            if (_currentSequence[i] != 0) continue;
                _currentSequence[i] = number;
                GetComponent<DisplayHandeler>().UpdateUi(string.Join("", _currentSequence));
                break;
        }
    }

    public void OnSubmit()
    {
        string currentInput = string.Join("", _currentSequence);
        if (currentInput != CorrectPassword)
        {
            ResetPassword();
            return;
        }

        Bob = GameObject.Find("DontDestroy").GetComponent<Commincation>();
        Bob.SendMsg(currentInput);  
    }
    public void ResetPassword()
    {
        Array.Clear(_currentSequence, 0, _currentSequence.Length);
        GetComponent<DisplayHandeler>().UpdateUi(string.Join(" ", _currentSequence));
    }
    
}

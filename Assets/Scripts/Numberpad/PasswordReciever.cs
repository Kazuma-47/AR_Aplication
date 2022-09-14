using System;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;


public class PasswordReciever : MonoBehaviour
{
    public GameObject VisualConfirm;    
    public string CorrectPassword;
    [SerializeField] private string serverURL;
    [SerializeField] private int[] _currentSequence = new int[4];
    private Commincation _server;

    

    public void AddNumberToPassword(int number)
    {
        for (int i = 0; i < _currentSequence.Length; i++)
        {
                    if (_currentSequence[i] != -1) continue;
                    _currentSequence[i] = number;
                GetComponent<DisplayHandeler>().UpdateUi(string.Join("", _currentSequence).Replace("-1", "0"));
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
        VisualConfirm.SetActive(true);
        VisualConfirm.GetComponent<DisapearTimer>().DisapearOnTimer(2f);
        _server = GameObject.Find("DontDestroy").GetComponent<Commincation>();
        _server.SendMsg("ZE HEBBEN DE JUISTE CODE");  
        ResetPassword();
    }
    public void ResetPassword()
    {
        for (int i = 0; i < _currentSequence.Length; i++)
        {
            if (_currentSequence[i] != -1)
                _currentSequence[i] = -1;
        }
        GetComponent<DisplayHandeler>().UpdateUi(string.Join("", _currentSequence).Replace("-1", "0"));
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHandeler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI display;

    public void UpdateUi(string value)
    {
        display.text = value;
    }
}

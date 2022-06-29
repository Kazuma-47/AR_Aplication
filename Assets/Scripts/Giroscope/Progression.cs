using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progression : MonoBehaviour
{
    public GameObject level;
    public GameObject newlevel;

    private void OnTriggerEnter(Collider other)
    {
        level.SetActive(false);
        newlevel.SetActive(true);
    }
}

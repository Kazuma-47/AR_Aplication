using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    [SerializeField] private string compareTag;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag(compareTag))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

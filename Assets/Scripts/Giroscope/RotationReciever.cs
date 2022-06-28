using System;
using UnityEngine;


public class RotationReciever : MonoBehaviour
{
    private bool _isFlat = true;
    [SerializeField] private float speedModifier = 7; 
    private Rigidbody _rigidbody;
    private float gravity = -7f;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    /*void Update()
    {
        Vector3 tilt = Input.acceleration;
        _rigidbody.velocity = new Vector3(tilt.x, gravity, tilt.y) * speedModifier;
    }*/
    
   
    void Update()
    {
        _rigidbody.AddForce(new Vector3(0, gravity,0)); 
        Vector3 tilt = Input.acceleration;

        if (_isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        tilt.y = gravity;
        _rigidbody.AddForce(tilt *speedModifier);
    } 
    
    public void SpeedChanged(string change)
    {
        if (change == "ramp")
        {
            gravity = -7f;
            speedModifier = 12f;
            //speedModifier = Mathf.Lerp(speedModifier , 10f, 1f);
        }
        
        else if (change == "rampup")
        {
            gravity = -0.3f;
            speedModifier = 16f;
            //speedModifier = Mathf.Lerp(speedModifier , 12f, 1f);

        }
        else
        {
            gravity = -7f;
            speedModifier = 7f;
            //speedModifier = Mathf.Lerp(speedModifier , 10f, 1f);
        }
    }
}
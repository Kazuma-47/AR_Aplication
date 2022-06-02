using UnityEngine;


public class RotationReciever : MonoBehaviour
{
    private bool _isFlat = true;

    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (_isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        
        _rigidbody.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.blue);
    }
}

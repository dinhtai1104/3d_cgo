using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObject : MonoBehaviour
{
    public float speedRotate;
    public Rigidbody carBody;
    // Update is called once per frame
    void Update()
    {
        // AD => xoay xe
        float xRotate = Input.GetAxis("Horizontal");
        if (xRotate != 0)
        {
            carBody.AddTorque(new Vector3(0, xRotate, 0) * speedRotate, ForceMode.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : Character
{
    // Update is called once per frame
    void Update()
    {
        float xLeftRight = Input.GetAxis("Horizontal");
        float zForwardbackward = Input.GetAxis("Vertical");
        if (xLeftRight != 0)
        {
            myRb.AddTorque(Vector3.up * rotateSpeed, ForceMode.Force);
        }

        var nextPos = transform.position + transform.forward * zForwardbackward * speed * Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, nextPos, 0.25f);
    }
}

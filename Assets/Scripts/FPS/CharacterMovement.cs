using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody objectHolding;
    public Rigidbody myRb;
    public float speed = 10;
    public float jumpForce = 10;

    // Update is called once per frame
    void Update()
    {
        float xLeftRight = Input.GetAxis("Horizontal");
        float zForwardbackward = Input.GetAxis("Vertical");
        transform.position += new Vector3(xLeftRight, 0, zForwardbackward) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Throw();
        }
    }

    private void Throw()
    {
        if (objectHolding == null) return;
        objectHolding.transform.SetParent(null);
        objectHolding.isKinematic = false;
        objectHolding.AddForce(Random.insideUnitSphere * 10);
        objectHolding = null;
    }

    private void Jump()
    {
        //myRb.velocity += new Vector3(0, jumpForce, 0);
        myRb.AddForce(new Vector3(0, jumpForce, 0));
    }
}

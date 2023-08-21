using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public ColorType playerColor;
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        float xLeftRight = Input.GetAxis("Horizontal");
        float zForwardbackward = Input.GetAxis("Vertical");
        transform.position += new Vector3(xLeftRight, 0, zForwardbackward) * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Brick"))
        {
            var brick = other.GetComponent<Brick>();
            if (brick != null)
            {
                var colorOfBrick = brick.brickColor;
                if (colorOfBrick == playerColor)
                {
                    Debug.Log("Collide with same color");
                    Destroy(other.gameObject);
                }
            }
        }
    }
}

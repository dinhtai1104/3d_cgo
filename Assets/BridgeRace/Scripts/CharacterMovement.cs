using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : Character
{
    public Joystick joystickInput;
    // Update is called once per frame
    void Update()
    {
        float xLeftRight = joystickInput.Horizontal;
        float zForwardbackward = joystickInput.Vertical;
        if (zForwardbackward != 0)
        {
            animator.SetFloat(velocityParameter, 1);
        }
        else
        {
            animator.SetFloat(velocityParameter, 0);
        }

        var direction = new Vector3(joystickInput.Horizontal, 0, joystickInput.Vertical).normalized;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        var targetQuaternion = Quaternion.LookRotation(direction, Vector3.up);

        transform.Translate(direction * Time.deltaTime * speed);
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQuaternion, rotateSpeed * Time.deltaTime);
        }
    }
}

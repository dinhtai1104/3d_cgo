using UnityEngine;

public class BotMovement : Character
{
    private void Update()
    {
        float xLeftRight = Random.Range(-1, 1);
        float zForwardbackward = Random.Range(-1, 1);
        if (xLeftRight != 0)
        {
            myRb.AddTorque(Vector3.up * rotateSpeed, ForceMode.Force);
        }

        var nextPos = transform.position + transform.forward * zForwardbackward * speed * Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, nextPos, 0.25f);
    }
}
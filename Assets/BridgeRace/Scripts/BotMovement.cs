using UnityEngine;

public class BotMovement : Character
{
    private void Update()
    {
        float xLeftRight = Random.Range(-1, 1);
        float zForwardbackward = Random.Range(-1, 1);

        if (zForwardbackward != 0)
        {
            animator.SetFloat(velocityParameter, 1);
        }
        else
        {
            animator.SetFloat(velocityParameter, 0);
        }

        var nextPos = transform.position + transform.forward * zForwardbackward * speed * Time.deltaTime + transform.right * xLeftRight * speed * Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, nextPos, 0.25f);
    }
}
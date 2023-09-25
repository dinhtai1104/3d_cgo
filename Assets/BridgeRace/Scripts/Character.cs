using UnityEngine;

public class Character : MonoBehaviour
{
    public ColorType playerColor;
    public float speed = 10;
    public float rotateSpeed = 10;
    public BagBrick bag;
    public Rigidbody myRb;
    public Animator animator;
    protected string velocityParameter = "velocity";
    private string TAG_BRICK = "Brick";


    public void XayCau()
    {
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.CompareTag(TAG_BRICK))
        {
            var brick = otherObject.GetComponent<Brick>();
            if (brick != null)
            {
                var colorOfBrick = brick.brickColor;
                if (colorOfBrick == playerColor)
                {
                    Debug.Log("Collide with same color");
                    bag.AddBrick(brick);
                }
            }
        }
    }
}
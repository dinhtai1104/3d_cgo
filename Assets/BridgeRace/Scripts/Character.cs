using UnityEngine;

public class Character : MonoBehaviour
{
    public ColorType playerColor;
    public float speed = 10;
    public float rotateSpeed = 10;
    public BagBrick bag;
    public Rigidbody myRb;


    public void XayCau()
    {
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.CompareTag("Brick"))
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
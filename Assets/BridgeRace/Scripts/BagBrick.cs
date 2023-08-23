using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagBrick : MonoBehaviour
{
    public float offsetBtwBrick = 0.3f;
    public List<Brick> _listBrick = new List<Brick>();

    public void AddBrick(Brick brick)
    {
        if (_listBrick.Count == 0)
        {
            brick.transform.SetParent(transform);
            brick.transform.localEulerAngles = Vector3.zero;
            brick.transform.localPosition = Vector3.zero;
            _listBrick.Add(brick);
            return;
        }
        var latestBrick =_listBrick[_listBrick.Count - 1];
        var latestPos = latestBrick.transform.localPosition;
        var newPos = latestPos + new Vector3(0, offsetBtwBrick, 0);

        brick.transform.SetParent(transform);
        brick.transform.localEulerAngles = Vector3.zero;
        brick.transform.localPosition = newPos;
        _listBrick.Add(brick);
    }
}

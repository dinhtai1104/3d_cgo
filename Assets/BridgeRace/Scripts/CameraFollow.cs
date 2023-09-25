using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    private Transform transformCached;
    private void Start()
    {
        transformCached = transform;
        offset = transform.position - target.position;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        transformCached.position = target.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkakeCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(Shake());
        }
    }

    private IEnumerator Shake()
    {
        float time = 1f;
        float current = 0;
        var waitForFrame = new WaitForSeconds(0.015f);
        while (current < time)
        {
            transform.position += Random.onUnitSphere * 0.2f;
            current += Time.deltaTime;
            yield return waitForFrame;
        }
    }
}

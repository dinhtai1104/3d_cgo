using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceByScripts : MonoBehaviour
{
    public LayerMask layerMask;
    public float forceMode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10000, layerMask))
            {
                Debug.Log(hit.transform.name);
                Debug.Log("hit");
                var ragdoll = hit.transform.GetComponent<RagdollCharacter>();
                if (ragdoll != null)
                {
                    ragdoll.Dead();
                }
            }
        }
    }
}

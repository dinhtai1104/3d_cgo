using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeChange : MonoBehaviour
{
    public Volume postProcessing;
    public Vignette vignette;
    public LensDistortion lens;
    // Start is called before the first frame update
    void Start()
    {
        postProcessing.profile.TryGet<Vignette>(out vignette); 
        postProcessing.profile.TryGet<LensDistortion>(out lens); 
    }

    // Update is called once per frame
    void Update()
    {
        lens.intensity.value += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vignette.active = true;
        }
    }
}

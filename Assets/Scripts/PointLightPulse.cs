using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightPulse : MonoBehaviour
{

    private Light light;
    public float pulseAmp = 1f;
    public float pulseSpeed = 1f;
    private float baseValue;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        baseValue = light.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = baseValue + Mathf.Sin(Time.time * pulseSpeed) * pulseAmp;
    }
}

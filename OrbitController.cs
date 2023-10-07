using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    [SerializeField]
    Transform SolarSystemCenter, MoonPivot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        SolarSystemCenter.localRotation = Quaternion.Euler(0, 10 * (float)time.TotalSeconds, 0);
        MoonPivot.localRotation = Quaternion.Euler(0, 120 * (float)time.TotalSeconds, 0);
    }
}

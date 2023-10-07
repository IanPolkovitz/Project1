using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamUpDown : MonoBehaviour
{
    [SerializeField]
    Transform camera;

    float yInitial;
    // Start is called before the first frame update
    void Start()
    {
        yInitial = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        TimeSpan time = DateTime.Now.TimeOfDay;
        camera.transform.position = new Vector3(transform.position.x, yInitial + Mathf.PingPong(Time.time * 2, 25), transform.position.z);//move on y axis only

    }
}

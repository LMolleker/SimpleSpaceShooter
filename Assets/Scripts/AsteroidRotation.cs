﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

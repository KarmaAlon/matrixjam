﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleGameBallController : MonoBehaviour
{

    [SerializeField] private float Speed = 1;

    [SerializeField] private Vector3 inputVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.z = Input.GetAxis("Vertical");
        gameObject.GetComponent<Rigidbody>().AddForce(inputVector * Speed);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaling : MonoBehaviour {

    public float scaleAmount = 3.0f;

	// Use this for initialization
	void Start () {
		
	}
	
    

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.G))
        {
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            //this.transform.localScale = Vector3.one * scaleAmount;
        }
    }
}

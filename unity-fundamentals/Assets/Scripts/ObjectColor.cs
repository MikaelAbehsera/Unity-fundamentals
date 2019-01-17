using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour {

    public Color changedColor = Color.white;
    public Color originalColor = Color.white;


    /// <summary>
    /// Start this instance.
    /// </summary>
    void Start () {
		
	}

    /// <summary>
    /// Awake this instance.
    /// </summary>
    void Awake()
    {
        originalColor = this.GetComponent<Renderer>().material.color;
    }

    /// <summary>
    /// Update this instance.
    /// </summary>
    void Update () {
        var Renderer = GetComponent<Renderer>();


        if (Input.GetKeyDown(KeyCode.G))
        {
            this.GetComponent<Renderer>().material.color = changedColor;
        } else if ( Input.GetKeyUp(KeyCode.G))
        {
            this.GetComponent<Renderer>().material.color = originalColor;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaling : MonoBehaviour {

    public float scaleAmount = 3.0f;
    public Vector3 originalScale = Vector3.zero;

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
        originalScale = this.transform.localScale;
    }

    /// <summary>
    /// Update this instance.
    /// </summary>
    void Update () {
		if (Input.GetKeyDown(KeyCode.G))
        {
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            //this.transform.localScale = Vector3.one * scaleAmount;

        }
        else if(Input.GetKeyUp(KeyCode.G))
        {
            this.transform.localScale = originalScale;
        }
    }
}

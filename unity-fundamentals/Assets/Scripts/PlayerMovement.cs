using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5.0f;

	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.UpArrow) )
        {
            Debug.Log("Key UpArrow Pressed.");

            this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
    }
}

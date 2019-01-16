using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5.0f;
    public float rotateSpeed = 60.0f;


	// Update is called once per frame
	void Update () {

        //Movement();

        if(Input.GetKey (KeyCode.LeftArrow))
        {
            Debug.Log("Key LeftArrow Pressed: Rotate");

            this.transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Key RightArrow Pressed: Rotate");

            this.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
        }
    }

    void Movement ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Key UpArrow Pressed.");

            this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Key DownArrow Pressed.");

            this.transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Key LeftArrow Pressed.");

            this.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Key RightArrow Pressed.");

            this.transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Key W Pressed.");

            this.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Key S Pressed.");

            this.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("5"))
        {
            transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        }
        if (Input.GetKey("6"))
        {
            transform.Translate(-Vector3.forward * 20 * Time.deltaTime);
        }
        if (Input.GetKey("7"))
        {
            transform.Translate(Vector3.down * 20 * Time.deltaTime);
        }
        if (Input.GetKey("8"))
        {
            transform.Translate(-Vector3.down * 20 * Time.deltaTime);
        }
        if (Input.GetKey("9"))
        {
            transform.Rotate(Vector3.up * -50 * Time.deltaTime);
        }
        if (Input.GetKey("0"))
        {
            transform.Rotate(Vector3.up * 50 * Time.deltaTime);
        }
    }
}

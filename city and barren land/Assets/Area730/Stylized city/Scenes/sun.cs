using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour {
    Vector3 pos = new Vector3 (-109f,250f,527f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(pos, Vector3.right, 10f * Time.deltaTime);
        transform.LookAt(pos);
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public Animator anim;

    private float inputH;
    private float inputV;
    private bool run;
    public Rigidbody rbody;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        run = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1"))
        {
            anim.Play("WAIT01", -1, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("WIN00", -1, 0f);
        }
        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT04", -1, 0.1f);
        }
        if(Input.GetMouseButtonDown(0)) 
        {
            int n = Random.Range(0, 2);
            if (n == 0)
            {
                anim.Play("DAMAGED00", -1, 0f);
            }
            else
            {
                anim.Play("DAMAGED01", -1, 0f);
            }
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");



        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        anim.SetBool("run", run);
        float moveX = inputH * 20f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;

        if(moveZ <= 0f)
        {
            moveX = 0f;
        }
        else if(run)
        {
            moveX *= 5f;
            moveZ *= 5f;
        }

        rbody.velocity = new Vector3(moveX,0f,moveZ);
    }
}

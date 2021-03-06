﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaScr : MonoBehaviour {

    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;

	// Use this for initialization
	void Start () {
        rb.AddForce(new Vector2(ballForce, ballForce));
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
	}
}

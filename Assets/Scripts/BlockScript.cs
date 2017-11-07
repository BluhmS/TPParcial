﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {

    public UIManager ui;

	// Use this for initialization
	void Start () {
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Pelota")
        {
            ui.incrementarScore();
            BreakIt();
            
        }

    }

    void BreakIt()
    {
        Destroy(this.gameObject, 0.1f);
    }
    
}

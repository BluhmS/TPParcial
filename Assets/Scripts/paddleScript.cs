using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public float MaxX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        if (x > 0)
        {
            MoverDerecha();
        }

        if (x < 0)
        {
            MoverIzquierda();
        }

        if (x == 0)
        {
            stop();
        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-MaxX,MaxX);
        transform.position = pos;

	}

    void MoverDerecha()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void MoverIzquierda()
    {
        rb.velocity = new Vector2(-speed, 0);
    }


    void stop()
    {
        rb.velocity = Vector2.zero;
    }
}

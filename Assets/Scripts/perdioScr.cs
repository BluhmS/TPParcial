using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class perdioScr : MonoBehaviour
{
    public UIManager ui;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Pelota")
        {
            ui.LoadScene("Menu");
        }

    }
}
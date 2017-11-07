using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    int score = 0;
    public Text scoreText;

    
	public void LoadScene(string SceneLevel)
    {
        SceneManager.LoadScene(SceneLevel);
    }

    public void incrementarScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

}

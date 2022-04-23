using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private int score;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Wrong")
            Loader.Load(Loader.Scene.playagain);
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Correct")
        {
            Destroy(target.gameObject);
            score++;
        }
    }
}

﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class levelTimeScript : MonoBehaviour {

    
    public Text levelGUI;
    public Text timeGUI;
    public Text scoreGUI;
    public moveScript moveScript;
    public gameOverScript gameOverScript;

    private int level = 1;
    private float time = 30f;
    private float score = 0f;

    private int countBorder = 2000;
    private int count = 0;

    void Start()
    {
        levelGUI.text = "Level: " + level.ToString();
        timeGUI.text = time.ToString();
        scoreGUI.text = "Score: " + score.ToString();
        Time.timeScale = 1;
    }

    void Update()
    {
        //タイム
        time -= 1f * Time.deltaTime;
        score += 1f * Time.deltaTime;
        timeGUI.text = ((int)time).ToString();
        scoreGUI.text = "Score: "+((int)score).ToString();
        //レベル
        if (transform.position.z >= countBorder)
        {
            countBorder += 2000;
            count++;
            if (count <= 8)
            {
                LevelUp();
            }
            AddTime();
        }

        if (time < 0.0f)
        {
            GameOver();
            
        }
    }

    void LevelUp()
    {
        if (count == 1) { level = 2; }
        if (count == 3) { level = 3; }
        if (count == 5) { level = 4; }
        if (count == 8) { level = 5; }
        moveScript.level = level;
        levelGUI.text = "Level: " + level.ToString();
    }

    void AddTime()
    {
        if (level == 2) { time += 20; }
        if (level == 3) { time += 17; }
        if (level == 4) { time += 15; }
        if (level == 5) { time += 10; }
    }
    void GameOver()
    {
        gameOverScript.SendMessage("Lose");
        Time.timeScale = 0;
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("title");
        }
    }
}
﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOverScript : MonoBehaviour {


    void Start()
    {
        this.gameObject.GetComponent<Text>().enabled = false;
    }

    public void Lose()
    {
       this.gameObject.GetComponent<Text>().enabled = true;
    }
}
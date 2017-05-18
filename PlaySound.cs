using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlaySound : MonoBehaviour
{

    private AudioSource sound01;
    private float time = 0f;

    void Start()
    {
        sound01 = GetComponent<AudioSource>();
        Time.timeScale = 1;

    }


    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            sound01.Play();
        }
    }
}
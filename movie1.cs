using UnityEngine;
using System.Collections;

public class movie1 : MonoBehaviour {
    int x;
    public int time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z >= 20199)
        {
            x++;
            time = 0;
        }
        if (x == 1) { Application.OpenURL("http://www.tsuyama-ct.ac.jp/"); }
    }
}

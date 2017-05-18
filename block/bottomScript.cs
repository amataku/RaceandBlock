using UnityEngine;
using System.Collections;

public class bottomScript : MonoBehaviour {
    public GameObject gameOver;
    bool goTitle = false;

    void Update () {
        if (goTitle)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel("op");
            }
        }
	
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        gameOver.SendMessage("Lose");
        goTitle = true;
    }
}

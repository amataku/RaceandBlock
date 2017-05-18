using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameClearScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Text>().enabled = false;
	
	}
	

	public void Win () {
        gameObject.GetComponent<Text>().enabled = true;
	
	}
}

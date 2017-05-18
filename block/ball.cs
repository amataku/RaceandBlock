using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
    public GameObject gameClear;
	private float speed = 12.5f;
    public int blockCt = 1;
    Vector3 v;

    
// Use this for initialization
    void Start () {

        Time.timeScale = 1;
        if (speed > 12.5f) { speed = 12.5f; }
        this.GetComponent<Rigidbody> ().AddForce (
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);
        if (speed > 12.5f) { speed = 12.5f; }


    }

	// Update is called once per frame
	void Update () {
        if (blockCt == 0)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameClear.SendMessage("Win");
            if (Input.GetMouseButtonDown(0))
            {
                Application.LoadLevel("op");
            }
        }
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "block")
        {
            blockCt -= 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballAction : MonoBehaviour {

    GameManger gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManger>();	
	}
	
	// Update is called once per frame
	void Update () {
	    if ( Input.GetKeyDown(KeyCode.Space) )
        {
            this.transform.position = new Vector3( -3.43f, 1.99f, -3.81f);
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); ;
            this.GetComponent<Rigidbody>().AddForce(new Vector3 (32, 50, -90), ForceMode.Impulse);
        }	
	}

    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);
        if ( other.gameObject.tag == "kugi" ) {
            gameManager.ScoreUpdate(30);
        }
    }
}

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
		
	}

    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);
        if ( other.gameObject.tag == "kugi" ) {
            gameManager.ScoreUpdate(30);
        }
    }
}

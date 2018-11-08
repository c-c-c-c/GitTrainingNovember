using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

    private int score;
    public UnityEngine.UI.Text scoreLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScoreUpdate(int point)
    {
        score = score + point;
        scoreLabel.text = "Score:" + score.ToString("D4");
    }
}

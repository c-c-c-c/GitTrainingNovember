using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManger : MonoBehaviour {

    private int score;
    [SerializeField]
    private TextMeshProUGUI scoreLabel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ScoreUpdate(int point)
    {
        score = score + point;
        scoreLabel.text = score.ToString("D4");
    }
}

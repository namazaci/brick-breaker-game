using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int lives;
	public int score;
	public Text livesText;
	public Text scoreText;
	
	// Use this for initialization
	void Start () {
		livesText.text = "Lives: " + lives;
		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

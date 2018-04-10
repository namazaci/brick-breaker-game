﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int lives;
	public int score;
	public Text livesText;
	public Text scoreText;
	public bool gameOver;
	public GameObject gameOverPanel;
	
	// Use this for initialization
	void Start () {
		livesText.text = "Lives: " + lives;
		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateLives(int changeInLives){
		lives += changeInLives;

		//Check for no lives left and trigger the end of the game
		if(lives <= 0)
		{
			lives = 0;
			GameOver();
		}

		livesText.text = "Lives: " + lives;
	}

	public void UpdateScore(int points){
		score += points; 

		scoreText.text = "Score: " + score;
	}

	void GameOver(){
		gameOver = true;
		gameOverPanel.SetActive(true);
	}

	public void PlayAgain(){
		SceneManager.LoadScene("Main");
	}
}

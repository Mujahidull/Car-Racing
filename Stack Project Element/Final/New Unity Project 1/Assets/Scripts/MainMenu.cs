﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
	public Text scoreText;
	private void Start()
	{
		scoreText.text = PlayerPrefs.GetInt ("score").ToString();
	}
	public void ToGame()
	{
		SceneManager.LoadScene ("Game");
	}

    public void Exit()
    {
        Application.Quit();
    }

}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public GameObject player;
    public bool gameOver;

	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {

	}
     public void CreditScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
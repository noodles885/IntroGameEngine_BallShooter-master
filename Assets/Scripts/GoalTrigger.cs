﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud 
// NSCC Truro 2022

public class GoalTrigger : MonoBehaviour
{    
    private GameObject gameManager;
    private GameManager _gameManager;
       

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController");
        _gameManager = gameManager.GetComponent<GameManager>();
    }   

    private void OnTriggerEnter(Collider other)
    {        
        _gameManager.GoalReached();
    }
}

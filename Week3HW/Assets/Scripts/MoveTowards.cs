﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class MoveTowards : MonoBehaviour
{
    public GameControl PlayerHealth;

    public GameControl PlayerScore;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Scene scene = SceneManager.GetActiveScene();
        PlayerHealth = GetComponent<GameControl>();
        PlayerScore = GetComponent<GameControl>();
        
        Debug.Log("The player health is" + PlayerHealth.health);
        Debug.Log("The player score is" + PlayerScore.score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //throw new System.NotImplementedException();
        
        transform.position = new Vector3(6, 5, 0);
        
        SceneManager.LoadScene("scene2");
    }
}
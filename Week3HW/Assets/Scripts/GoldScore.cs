﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
    	
    			
    	
        //print("I GOT HIT");
        if (other.gameObject.CompareTag("Player"))//if the collider attached the prize
        {
            
            //other.gameObject.GetComponent<GameControl>().score+= 10; //Get the GameController and add 10 score
            Destroy(gameObject); //Destroy the gameObject I am attached to
        }
        GameControl.instance.Score += 10;
    }
}



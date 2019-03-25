using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{  public Text PlayerHealth;
     public Text PlayerScore;
     
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
        GameControl myPlayer = new GameControl();
        myPlayer.Score = 0;
        int x = myPlayer.Score;
        
        myPlayer.Health = 50;
        int y = myPlayer.Health;
    }

    // Update is called once per frame
    void Update()
    {
         
        if (Input.GetMouseButtonDown(0))
        {
            //x ++;
           // y -= 5;
        }
        PlayerHealth.text = "Health "+ GameControl.instance.Health;
        PlayerScore.text = "Score " + GameControl.instance.Score; 
    }

    
}

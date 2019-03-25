using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    [SerializeField]
    int health = 50;//poverty 的写法
    public int Health
    {
        
        get{
            return health;
        }
        set
        {
            health = value;
            if (health > 100)
            {
                health = 100;
            }

            if (health < 10)
            {
                health = 0;
                Die();
            }
            
            print("health was set to:" + Health);

            
        }
    }
    
    public int score = 0;

    public int Score
    {
        get { return score; }
        set
        {
            
            
            print("score was set to:" + value);
            score = value;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        
        
        Health = 50;
        
        
        Debug.Log(Health);
      

    }

   
    
    public void Die()
    {
        Debug.Log("Sorry you die lol");
    }

    // Update is called once per frame
    void Update()
    {

      // if (Input.GetMouseButtonDown(0))
                 //  {
                 //      Health -= 5;
                  //     print("health was set to:" + Health);
                  // }
        
        //print("Your current score is:"+Score);

        
    }
}
    

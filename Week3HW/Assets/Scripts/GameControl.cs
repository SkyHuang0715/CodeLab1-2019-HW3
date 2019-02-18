using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Text PlayerHealth;
    public Text PlayerScore;
    
    public int health = 50;//poverty 的写法
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
            }
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
        DontDestroyOnLoad(this.gameObject);
      

    }

    // Update is called once per frame
    void Update()
    {

        PlayerHealth.text = ""+health;
        PlayerScore.text = "" + score;
        
        if (Input.GetMouseButtonDown(0))
        {
            Score ++;
            health--;
        }
        
        print("Your current score is:"+Score);

    }
}
    

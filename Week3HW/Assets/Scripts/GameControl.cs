using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameControl : MonoBehaviour
{
    int health;//poverty 的写法
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
    
    int score = 0;

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

    }

    // Update is called once per frame
    void Update()
    {
        Score ++;
        print("Your current score is:"+Score);

    }
}
    

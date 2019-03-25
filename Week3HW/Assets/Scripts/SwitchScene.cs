using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SwitchScene : MonoBehaviour
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
        //throw new System.NotImplementedException();
        // -= 5;
        if (other.gameObject.CompareTag("Player")) //if the collider attached the door
        {
            // transform.position = new Vector3(0, 4, 0);
            GameObject player = GameObject.Find("Player");
            GameObject controller = GameObject.Find("GameController");
            GameObject manager = GameObject.Find("GameManager");
            if (player)
            {
                Destroy(player.gameObject);
                Debug.Log(player + "has been reloaded"); //reload cube if player back to scene1
                
                Destroy(controller.gameObject);
                Destroy(manager.gameObject);
            }

            SceneManager.LoadScene("SampleScene");
            Debug.Log("Good to see you again!");
        }
    }
}

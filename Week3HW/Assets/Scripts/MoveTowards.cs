using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTowards : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Scene scene = SceneManager.GetActiveScene();
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

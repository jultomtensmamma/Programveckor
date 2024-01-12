using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script2 : MonoBehaviour
{
    // den här coden gör så att man kan byta scen genom att trycka på en tangent
    public void Start()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("GameScene");
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

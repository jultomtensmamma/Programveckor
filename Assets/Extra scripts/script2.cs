using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script2 : MonoBehaviour
{
    // den h�r coden g�r s� att man kan byta scen genom att trycka p� en tangent
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

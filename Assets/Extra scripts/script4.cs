using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script4 : MonoBehaviour
{
    int number;

    // det här scriptet gör att man kan byta scen beroende på vad som händer i spelet. Man för byta ut "gamescene" till den scen som man vill använda

    public void Play()
    {
        if(number == 1)
        {
            SceneManager.LoadScene("GameScene");
        }
        else if(number == 2)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

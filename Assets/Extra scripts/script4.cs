using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script4 : MonoBehaviour
{
    int number;

    // det h�r scriptet g�r att man kan byta scen beroende p� vad som h�nder i spelet. Man f�r byta ut "gamescene" till den scen som man vill anv�nda

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

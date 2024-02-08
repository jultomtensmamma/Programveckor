using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu2 : MonoBehaviour
{
    //Mira Sköld
    // Används för att starta spelet
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu2 : MonoBehaviour
{
    //Mira Sk�ld
    // Anv�nds f�r att starta spelet
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
    
}

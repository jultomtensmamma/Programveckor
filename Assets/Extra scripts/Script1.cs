using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{
    
    // Det h�r scriptet g�r att man kan byta csen med hj�lp av knappar. F�r att detta scxriptet ska kunna anv�ndas s� m�sta man l�gga in scriptet i knappen
   
    public void Play()
    {
        SceneManager.LoadScene("GameScene");// Man kan byta vilken scen den ska byta till
    }
}

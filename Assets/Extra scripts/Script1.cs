using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour
{
    
    // Det här scriptet gör att man kan byta csen med hjälp av knappar. För att detta scxriptet ska kunna användas så måsta man lägga in scriptet i knappen
   
    public void Play()
    {
        SceneManager.LoadScene("GameScene");// Man kan byta vilken scen den ska byta till
    }
}

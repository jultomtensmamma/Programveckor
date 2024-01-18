using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script2 : MonoBehaviour
{
    // den här coden gör så att man kan byta scen genom att trycka på en tangent. För att den ska fungera så måste man göra en knapp och lägga in scriptet i knappen och välja funktionen "Play". DEt går att byta tangent och vilken scen den ska byta till
    public string sceneName;
    public void Play()
    {
        print("hej");
        SceneManager.LoadScene(sceneName);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Play();
    }
}

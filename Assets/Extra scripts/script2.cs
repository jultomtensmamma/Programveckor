using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script2 : MonoBehaviour
{
    // den h�r coden g�r s� att man kan byta scen genom att trycka p� en tangent. F�r att den ska fungera s� m�ste man g�ra en knapp och l�gga in scriptet i knappen och v�lja funktionen "Play". DEt g�r att byta tangent och vilken scen den ska byta till
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script3 : MonoBehaviour
{
    [SerializeField]
    GameObject variable;
    //den här gör att en text kan visas när man trycker ner en tangent. För att koden ska fungera behöver man byta ut "Variable" till en variabel som texten har
    public void Start()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(variable);
        }

    }
    public void Play()
    {
        Instantiate(variable);// den här gör att man kan få en text att visas vid en knapptryckning. För att den ska fungera så behöver man skapa en knapp och lägga in skriptet i den knappen och välja funktionen "Play"
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script3 : MonoBehaviour
{
    [SerializeField]
    GameObject variable;
    //den h�r g�r att en text kan visas n�r man trycker ner en tangent. F�r att koden ska fungera beh�ver man byta ut "Variable" till en variabel som texten har
    public void Start()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(variable);
        }

    }
    public void Play()
    {
        Instantiate(variable);// den h�r g�r att man kan f� en text att visas vid en knapptryckning. F�r att den ska fungera s� beh�ver man skapa en knapp och l�gga in skriptet i den knappen och v�lja funktionen "Play"
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

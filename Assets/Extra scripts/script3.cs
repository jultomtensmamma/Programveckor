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
            Instantiate(variable, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
        }

    }
    public void Play()
    {
        Instantiate(variable, transform.position + new Vector3(0, 0, 0), Quaternion.identity);// den h�r g�r att man kan f� en text att visas vid en knapptryckning
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

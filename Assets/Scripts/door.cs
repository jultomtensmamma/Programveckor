using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Mira sk�ld
    // detta script anv�nds f�r att �ppna och st�nga d�rrar
    public GameObject opendoor;
    public GameObject closeddoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("Opendoor", 5);
        }
    }
    void Opendoor()
    {
        closeddoor.SetActive(false);
        opendoor.SetActive(true);
    }
}

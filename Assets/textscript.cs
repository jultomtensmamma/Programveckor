using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textscript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]
    GameObject text;
    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}

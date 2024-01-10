using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    int hitpoint = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage()
    {
      
        hitpoint -= 1;
        if (hitpoint == 0)
        {
            Destroy(gameObject);
        }
    }
}

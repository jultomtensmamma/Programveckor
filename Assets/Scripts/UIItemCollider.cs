using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItemCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;

    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject != null)
        {
            sr.enabled = true;
        }

    }
}
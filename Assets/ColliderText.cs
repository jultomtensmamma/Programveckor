using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColliderText : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI texten;
    public GameObject dialogueBox;
    void Start()
    {
        dialogueBox.SetActive(false);

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag== "Player")
        {
            dialogueBox.SetActive(true);

        }
       
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        dialogueBox.SetActive(false);

    }
}

//HCS
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{

    public TextMeshProUGUI textBox;
    private bool isPlayerInside = false;
    public string message = "Hello, Player!"; // Customize your message here

    void Start()
    {
        
        textBox.gameObject.SetActive(false);
    
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            textBox.text = message;
            textBox.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            textBox.gameObject.SetActive(false);
        }
    }
}
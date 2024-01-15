using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialog : MonoBehaviour
{
    
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;

    private GameObject dialogueBox;

    void Start()
    {
        StartCoroutine(Type());
        CloseDialogueBox();
    }

    private void Update()
    {
        if (textDisplay.text == sentences[index]) 
        {
            continueButton.SetActive(true);
        }
    }

    // V�nta n�gra sekunder innan man trycker p� continue
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }

        CloseDialogueBox();
    }

    // continue button trycka och g� till n�sta dialog
    public void NextSentence()
    {
        continueButton.SetActive(false);
        
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        { 
         textDisplay.text = "";
         continueButton.SetActive(false);
        }
    }

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textDisplay.text = string.Empty;
    }
}
    
    
    
    
    
   
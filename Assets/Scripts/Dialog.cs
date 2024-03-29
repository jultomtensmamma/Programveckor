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
    public GameObject dialogueBox;
    public GameObject rain;
    public AudioSource TalkingSound;

    void Start()
    {
        StartCoroutine(Type());
        
    }

    public void Update()
    {
        if (textDisplay.text == sentences[index]) 
        {
            continueButton.SetActive(true);
            TalkingSound.enabled = true;
        }
       else
        {
            TalkingSound.enabled = false;

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

        
    }

    // continue button trycka och g� till n�sta dialog
    public void NextSentence()
    {
        if (index == 1)
        {
            rain.SetActive(true);
        }
        continueButton.SetActive(false);

        // regn funktion och closedialog
        
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
         CloseDialogueBox();
        }
    }


    //Dialogboxen ska bort

    private void CloseDialogueBox()
    {
        dialogueBox.SetActive(false);
        textDisplay.text = string.Empty;
    }
}
    
    
    
    
    
   
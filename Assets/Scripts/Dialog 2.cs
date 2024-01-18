using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog2 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;
    

    void Start()
    {
        StartCoroutine(Type());

    }

    public void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    // Vänta några sekunder innan man trycker på continue
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }


    }

    // continue button trycka och gå till nästa dialog
    public void NextSentence()
    {
        
      
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;



    void start()
    {
        textComponent.text = string.Empty;
        StartNewBehaviourScript();

    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                Nextline();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }

        }

    }


    void StartNewBehaviourScript()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {


        foreach (char c in lines[index].ToCharArray())
        {

            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);

        }
    }

    void Nextline()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
        }

    }

}
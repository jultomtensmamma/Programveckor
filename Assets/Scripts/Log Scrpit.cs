using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogScrpit : MonoBehaviour
{
    private bool isPlayerInside;
   
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
            if (gameObject.CompareTag("deer sprite walking spreadsheet_0"))
            {
                isPlayerInside = true;
               SceneManager.LoadScene("GameScene");
            }
        
    }
}

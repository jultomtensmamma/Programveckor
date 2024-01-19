using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class SwitchScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("Inside Trigger Zone");
            SceneManager.LoadScene("Log2");

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Outside Trigger Zone");
    }
}
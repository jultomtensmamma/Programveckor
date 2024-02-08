
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class LogScript : MonoBehaviour
{
    // Mira Sk�ld
    // Scenbyte
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Teleport();
        }
    }

    private void Teleport()
    {
        SceneManager.LoadScene(2);
       
    }

}
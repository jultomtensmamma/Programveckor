using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood_walking_sound : MonoBehaviour
{
    public AudioSource WoodWalkingSound;
    void Start()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {

            WoodWalkingSound.enabled = true;
        }
        else
        {
            WoodWalkingSound.enabled = false;
        }
    }

 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script3 : MonoBehaviour
{//objectpickup
    
    public int Objectvalue = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            IInventory inventory = other.GetComponent<IInventory>();

            if(inventory != null)
            {
                inventory.objects = inventory.objects + Objectvalue;
                print("Player has" + inventory.objects + "objects in their inventory");
                gameObject.SetActive(false);
            }
        }
    }
}

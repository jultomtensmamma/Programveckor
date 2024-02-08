using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script1 : MonoBehaviour, IInventory
    //Mira Sköld
{  //playerinventory
    public int objects { get => _Object; set => _Object = value; }

    public int _Object = 0;
}

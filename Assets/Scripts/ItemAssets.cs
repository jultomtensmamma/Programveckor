using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }
    private void Awake() {
        Instance = this;
    }
        
            public Sprite RedKey;
            public Sprite BlueKey;
            public Sprite GreenKey;
            public Sprite Berries;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarUI : MonoBehaviour
{
    public static HotbarUI hotbar;
    
    private void Awake()
    {
         if (hotbar== null)
        {
            hotbar = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

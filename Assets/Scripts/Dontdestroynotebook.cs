using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroynotebook : MonoBehaviour
{
    public static Dontdestroynotebook notebook;

    private void Awake()
    {
        if (notebook == null)
        {
            notebook = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

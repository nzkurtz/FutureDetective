using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHide : MonoBehaviour
{

    public GameObject text;
    private bool toggleBool;
    // Start is called before the first frame update
    void Awake()
    {
        text.SetActive(false);
    }

    public void textAppear(){
        toggleBool = !toggleBool;
        text.SetActive(toggleBool);
    }
}

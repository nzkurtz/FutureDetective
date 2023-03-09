using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalToggle : MonoBehaviour
{

    public GameObject notebook;
    private bool toggleBool;
    // Start is called before the first frame update
    void Awake()
    {
        notebook.SetActive(false);
    }

    public void ToggleJournal(){
        toggleBool = !toggleBool;
        notebook.SetActive(toggleBool);
    }
}

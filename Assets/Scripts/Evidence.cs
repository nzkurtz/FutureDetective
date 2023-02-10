using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    public NotebookTab notebookTab;
    public string evidence;

    private void OnTriggerEnter2D(Collider2D collider){
        notebookTab.page.evidence.Add("\n"+evidence);
        notebookTab.Clicked();
    }
    
        
    
}

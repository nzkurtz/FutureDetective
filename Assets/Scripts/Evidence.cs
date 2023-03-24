using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    public NotebookTab notebookTab;
    public Page page;
    public string evidence;
    public bool UVLight;
    public GameObject UV;
    public bool interactedWith;

    private void OnTriggerEnter2D(Collider2D collider){
        if(!interactedWith){
        if(!UVLight){
            
            notebookTab.page.evidence.Add("\n"+evidence);
            notebookTab.Clicked();
            }
        
        else if(UVLight){
            if(UV.activeInHierarchy){
                notebookTab.page.evidence.Add("\n"+evidence);
                notebookTab.Clicked();
            }
        }
        }
    }
    private void OnTriggerExit2D(Collider2D collider){
        interactedWith = true;
    }
        
    
}

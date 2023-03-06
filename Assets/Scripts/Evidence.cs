using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    public NotebookTab notebookTab;
    public string evidence;
    public bool UVLight;
    public GameObject UV;
    private void OnTriggerEnter2D(Collider2D collider){
        if(!UVLight){
            if(!notebookTab.page.evidence.Contains(evidence)){
            notebookTab.page.evidence.Add("\n"+evidence);
            notebookTab.Clicked();
            }
        }
        else if(UVLight){
            if(UV.activeInHierarchy){
                notebookTab.page.evidence.Add("\n"+evidence);
                notebookTab.Clicked();
            }
        }
    }
    
        
    
}

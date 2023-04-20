using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    public int notebookIndex;
    public string evidence;
    public bool UVLight;
    public GameObject UV;
    public bool interactedWith;

    private Notebook notebook;

    private void Start()
    {
        notebook = Dontdestroynotebook.notebook.GetComponentInChildren<Notebook>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(!interactedWith)
        {
            if(!UVLight)
            {
                notebook.tabs[notebookIndex].GetComponent<NotebookTab>().page.evidence.Add("\n"+evidence);
                notebook.tabs[notebookIndex].GetComponent<NotebookTab>().Clicked();
            }
        }
        else if(UVLight){
            if(UV.activeInHierarchy){
                notebook.tabs[notebookIndex].GetComponent<NotebookTab>().page.evidence.Add("\n"+evidence);
                notebook.tabs[notebookIndex].GetComponent<NotebookTab>().Clicked();
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D collider){
        interactedWith = true;
    }
        
    
}

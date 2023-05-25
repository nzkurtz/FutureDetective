using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum SusPerson {Harold, Jacklyn, Sion, Mary, Jed, Wilmer, Joshua, Judie};
public class Evidence : MonoBehaviour
{
    public SusPerson notebookIndex;
    public string evidence;
    public bool UVLight;
    public GameObject UV;
    public bool interactedWith;

    private Notebook notebook;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        notebook = Dontdestroynotebook.notebook.gameObject.GetComponent<Notebook>();
        Debug.Log(notebook.gameObject + "HI");
        
        if(!interactedWith)
        {
            if(!UVLight)
            {
                notebook.tabs[(int)notebookIndex].GetComponent<NotebookTab>().page.evidence.Add("\n\n"+evidence);
                notebook.tabs[(int)notebookIndex].GetComponent<NotebookTab>().Clicked();
            }
        }
        else if(UVLight){
            if(UV.activeInHierarchy){
                notebook.tabs[(int)notebookIndex].GetComponent<NotebookTab>().page.evidence.Add("\n\n"+evidence);
                notebook.tabs[(int)notebookIndex].GetComponent<NotebookTab>().Clicked();
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D collider){
        interactedWith = true;
    }
        
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookTab : MonoBehaviour
{
    public Notebook notebook;
    public Page page;

    public void Clicked()
    {
        notebook.SetTitle(page.title);
        notebook.SetEvidence(page.evidence);
    }
}

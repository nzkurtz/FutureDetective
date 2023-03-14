using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookTab : MonoBehaviour
{
    public Notebook notebook;
    public Page page;

    private void Awake()
    {
        notebook.SetName(page.title);
        notebook.SetEvidence(page.evidence);
    }

    public void Clicked()
    {
        notebook.SetName(page.title);
        notebook.SetEvidence(page.evidence);
    }
}

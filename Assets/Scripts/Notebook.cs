using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Notebook : MonoBehaviour
{
    public TextMeshProUGUI title, evidence;
    public static Notebook notebook;
    
    private void Awake()
    {
         if (notebook == null)
        {
            notebook = this;
            DontDestroyOnLoad(gameObject.transform.root);
        }
        else
        {
            Destroy(gameObject.transform.root);
        }
    }

    public void SetName(string titleText)
    {
        title.text = titleText;
    }

    public void SetEvidence(List<string> evidenceList)
    {
        evidence.text = "";
        
        for (int i = 0; i < evidenceList.Count; i++)
        {
            evidence.text += (" " + evidenceList[i]);
        }
    }
}

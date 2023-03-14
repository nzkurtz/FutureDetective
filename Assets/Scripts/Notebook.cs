using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Notebook : MonoBehaviour
{
    public TextMeshProUGUI title, evidence;
    
    private void Awake()
    {
         
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tools {UVLight, Flashlight, SampleKit };

public class PlayerHotbar : MonoBehaviour
{
    public GameObject[] hotbar = new GameObject[0];
    public Tools tool;

    private void Update()
    {
        if (tool == Tools.Flashlight){

        }
        if(tool == Tools.UVLight){
            
        }
        if(tool == Tools.SampleKit){

        }
    }
}

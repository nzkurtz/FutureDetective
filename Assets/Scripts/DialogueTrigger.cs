using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public GameObject interactable;
    void Awake(){
        interactable.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collider){
        interactable.SetActive(true);
        
    }
    void OnTriggerStay2D(Collider2D collider){
        if(Input.GetKeyDown(KeyCode.E)){
            interactable.SetActive(false);
            Debug.Log("hi");
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger2 : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inky;
  
    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
               Debug.Log("interact"); 
                DialogueManager.GetInstance().EnterDialogueMode(inky);
                
                
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
       
       
        
        
    }
     private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
       
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
            
        }
        

    }

}

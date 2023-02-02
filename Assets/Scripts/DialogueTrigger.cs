using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public GameObject interactable;
    private bool playerInRange;
    private void Awake()
    {
        playerInRange = false;
        interactable.SetActive(false);
    }
    private void Update()
    {
        if (playerInRange ) //&& !DialogueManager.GetInstance().dialogueIsPlaying
        {
            interactable.SetActive(true);
            // if (Input.GetKeyDown("space"))
            // {
            //    Debug.Log("interact"); 
            //     DialogueManager.GetInstance().EnterDialogueMode(inky);
                
            // }
        }
        else
        {
            interactable.SetActive(false);
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

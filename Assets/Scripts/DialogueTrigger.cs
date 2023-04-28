using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inky;

    private bool playerInRange;
    public static int neighborsTalkedTo = 0;
    private GameObject ghost;
   
    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        ghost = GameObject.Find("ghost");
    }

    private void Start()
    {
        ghost.SetActive(false);
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
                neighborsTalkedTo += 1;
                
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
        if (neighborsTalkedTo >= 5){
            ghost.SetActive(true);
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
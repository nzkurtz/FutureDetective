using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inky;
    [SerializeField] private TextAsset inky2;

    private bool playerInRange;
    public static int neighborsTalkedTo = 0;
    private GameObject ghost;
    public static int closets = 0;

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
        Scene currentScene = SceneManager.GetActiveScene ();
        if (neighborsTalkedTo >= 5 && currentScene.name == "MainLevel"){
            ghost.SetActive(true);
        }
        if (closets >= 5){
            GameManager.entryDialogue = false;
            GameManager.EntryDialog();
            Debug.Log("Entry Dialogue: "+ GameManager.entryDialogue);
            DialogueManager.GetInstance().EnterDialogueMode(inky2);
           
            Debug.Log("hi"+ closets);
            

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
        if(gameObject.tag == "closet"){
            
            closets+=1;
            Debug.Log(closets);
        }
        if(gameObject.tag == "susaxe"){
            GameManager.SionConfession();
            GameManager.sionConfession = true;
        }

    }

    
}
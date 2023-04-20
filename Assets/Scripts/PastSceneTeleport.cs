using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PastSceneTeleport : MonoBehaviour
{

     [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    private bool playerInRange;
    public string level;

    private void Update()
    {
        if (playerInRange)
        {
            visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
               SceneManager.LoadScene(level);
                
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

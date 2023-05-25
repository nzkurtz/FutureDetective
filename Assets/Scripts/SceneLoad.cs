using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public string level;    
    public GameObject door;
    public bool playerDestroy;
   
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
      
        GameManager.gameManager.StartCoroutine(GameManager.gameManager.LoadScene3(level, door.name, playerDestroy));
        
    }
    public void Load(string level2){
        SceneManager.LoadScene(level2);
    }
    
   
    
}

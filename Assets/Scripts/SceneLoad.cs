using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneLoad : MonoBehaviour
{
    public string level;    
 
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameManager.gameManager.LoadScene3(level);
    }
}

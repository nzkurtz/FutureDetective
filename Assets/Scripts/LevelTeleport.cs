using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTeleport : MonoBehaviour
{
    public GameObject staircase;
    public GameObject player;
    public Vector3 offset;
  

  
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            player.transform.position = staircase.transform.position + offset;
            
        }
    }
}

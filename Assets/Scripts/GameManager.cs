using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public GameObject player;
    public Vector2 teleport;
    public Scene HaroldHouse;
    

    private void Awake()
    {
        
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        
    }
    public IEnumerator LoadScene3(string level, string doorName, bool playerDestroy){
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        if(playerDestroy){
            Destroy(player);
        }
        else{
            DontDestroyOnLoad(player);
        }
        
        SceneManager.LoadScene(level);
        yield return new WaitForSeconds(0.000001f);

        if(doorName == "MarySionDoor"){
            
            teleport = GameObject.Find("MarySionWelcome").transform.position;
            Debug.Log(teleport);
        } else if(doorName == "wilmerDoor"){
            teleport = GameObject.Find("wilmerWelcome").transform.position;
            Debug.Log(teleport);
        }   else if(doorName == "WilmerExit"){
            teleport = GameObject.Find("WilmerFront").transform.position;
        }
        else if(doorName == "MarySionExit"){
            teleport = GameObject.Find("MarySionFront").transform.position;
        }
        else if(doorName == "JoshuaJudieDoor"){
            teleport = GameObject.Find("JoshuaJudieWelcome").transform.position;
        }
        else if(doorName == "JoshuaJudieExit"){
            teleport = GameObject.Find("JoshuaJudieFront").transform.position;
        }
        
        else {teleport =  GameObject.Find("haroldWelcome").transform.position; Debug.Log("harold");}
        Debug.Log(teleport);
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        player.transform.position = teleport;
        Debug.Log("loaded");
        
        
    }
}

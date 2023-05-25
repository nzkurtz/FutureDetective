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
    public AudioSource audio;
    public static bool entryDialogue = true;
    public static bool sionConfession = false;
    public static bool end = false;

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
    private void Update(){
        
        if(entryDialogue){
            Debug.Log("Entry Dialogue: "+entryDialogue);
             GameObject.Find("Jed").GetComponent<DialogueTrigger>().enabled = true;
             GameObject.Find("Wilmer").GetComponent<DialogueTrigger>().enabled = true;
             GameObject.Find("Jacklyn").GetComponent<DialogueTrigger>().enabled = true;
             GameObject.Find("Sion").GetComponent<DialogueTrigger>().enabled = true;
             GameObject.Find("Joshua").GetComponent<DialogueTrigger>().enabled = true;
             
            GameObject.Find("Jed").GetComponent<DialogueTrigger2>().enabled = false;
             
             GameObject.Find("Sion").GetComponent<DialogueTrigger2>().enabled = false;
             
             
        }else{
            Debug.Log("Entry Dialogue: "+entryDialogue);
            GameObject.Find("Jed").GetComponent<DialogueTrigger>().enabled = false;
             GameObject.Find("Wilmer").GetComponent<DialogueTrigger>().enabled = false;
             GameObject.Find("Jacklyn").GetComponent<DialogueTrigger>().enabled = false;
             GameObject.Find("Sion").GetComponent<DialogueTrigger>().enabled = false;
             GameObject.Find("Joshua").GetComponent<DialogueTrigger>().enabled = false;
             
            GameObject.Find("Jed").GetComponent<DialogueTrigger2>().enabled = true;
             
             GameObject.Find("Sion").GetComponent<DialogueTrigger2>().enabled = true;
        }
        if(sionConfession){
            GameObject.Find("Jed").GetComponent<DialogueTrigger2>().enabled = false;
             
             GameObject.Find("Sion").GetComponent<DialogueTrigger2>().enabled = false;
            GameObject.Find("Sion").GetComponent<DialogueTrigger3>().enabled = true;
            end = true;
        }

    }
    public static void EntryDialog(){
        entryDialogue = false;
    }
    public static void SionConfession(){
        sionConfession = true;
    }
    public IEnumerator LoadScene3(string level, string doorName, bool playerDestroy){
        audio = GameObject.Find("DoorAudio").GetComponent<AudioSource>();
        audio.Play(0);
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
        else if(doorName == "JacklynDoor"){
            teleport = GameObject.Find("JacklynWelcome").transform.position;
        }
        else if(doorName == "JacklynExit"){
            teleport = GameObject.Find("JacklynFront").transform.position;
        }
        else if(doorName == "JedDoor"){
            teleport = GameObject.Find("JedWelcome").transform.position;
        }
        else if(doorName == "JedExit"){
            teleport = GameObject.Find("JedFront").transform.position;
        }
        else {teleport =  GameObject.Find("haroldWelcome").transform.position; Debug.Log("harold");}
        Debug.Log(teleport);
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        player.transform.position = teleport;
        Debug.Log("loaded");
        
        
    }
}

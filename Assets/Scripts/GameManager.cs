using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    [SerializeField] private List<GameObject> dontDestroys = new List<GameObject>();
    

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

        
        foreach (GameObject obj in dontDestroys)
        {
            DontDestroyOnLoad(obj);
        }
    }
    public void LoadScene3(string level){
        
        SceneManager.LoadScene(level);
        
       
    }
}

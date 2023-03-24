using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RainControl : MonoBehaviour
{
    public GameObject rain;
    // Update is called once per frame
    void Update()
    {
      
        if(SceneManager.GetActiveScene().name == "HaroldHouse"){
            rain.SetActive(false);
        }
        else{
            rain.SetActive(true);
        }
    }
}

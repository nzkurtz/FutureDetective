using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVLightControl : MonoBehaviour
{

    public GameObject light;
    private bool toggle;
    // Start is called before the first frame update
    void Awake()
    {
        toggle = false;
        light.SetActive(toggle);
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.R)){
            ToggleLight();
            Debug.Log("Clicked");
        }



        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            
            light.transform.rotation = Quaternion.Euler(0, 0, 135);
        }
        else if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A)){
             light.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S)){
            light.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        


            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                
                light.transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A)){
                light.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)){
                light.transform.rotation = Quaternion.Euler(0, 0, 90);
            }




           if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S))
            {
                
                light.transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            else if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)){
                light.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)){
                light.transform.rotation = Quaternion.Euler(0, 0, -90);
            }



              if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W))
            {
                
                light.transform.rotation = Quaternion.Euler(0, 0, -135);
            }
            else if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)){
                light.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            else if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W)){
                light.transform.rotation = Quaternion.Euler(0, 0, -90);
            }



      
    }
    public void ToggleLight(){
        toggle = !toggle;
        Debug.Log(toggle);
        light.SetActive(toggle);
    }
    
}

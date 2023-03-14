using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightControl : MonoBehaviour
{

    public GameObject flashlight;
    private bool toggle;
    // Start is called before the first frame update
    void Awake()
    {
        toggle = false;
        flashlight.SetActive(toggle);
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.F)){
            ToggleLight();
            Debug.Log("Clicked");
        }



        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            
            flashlight.transform.rotation = Quaternion.Euler(0, 0, 135);
        }
        else if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A)){
            flashlight.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S)){
            flashlight.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        


            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                
                flashlight.transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A)){
                flashlight.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)){
                flashlight.transform.rotation = Quaternion.Euler(0, 0, 90);
            }




           if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S))
            {
                
                flashlight.transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            else if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)){
                flashlight.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)){
                flashlight.transform.rotation = Quaternion.Euler(0, 0, -90);
            }



              if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W))
            {
                
                flashlight.transform.rotation = Quaternion.Euler(0, 0, -135);
            }
            else if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)){
                flashlight.transform.rotation = Quaternion.Euler(0, 0, 180);
            }
            else if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W)){
                flashlight.transform.rotation = Quaternion.Euler(0, 0, -90);
            }



      
    }
    public void ToggleLight(){
        toggle = !toggle;
        Debug.Log(toggle);
        flashlight.SetActive(toggle);
    }
    
}

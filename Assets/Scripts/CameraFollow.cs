using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variables
    public static CameraFollow cameraFollow;
    public Transform player;
    public Vector3 offset;
    
    void Awake()
    {
        if (cameraFollow == null)
        {
            cameraFollow = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LateUpdate()
    {
        transform.position = GameObject.FindGameObjectsWithTag("Player")[0].transform.position + offset;
    }
}

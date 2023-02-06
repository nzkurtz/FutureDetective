using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //variables
    public Transform player;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}

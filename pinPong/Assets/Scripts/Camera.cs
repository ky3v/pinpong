
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float distance = -9.0f;
    public float height = 1.5f;
    public GameObject targetObject;

   
    // Update is called once per frame
    void LateUpdate()
    {
        if (targetObject == null)
        {
            return;
        }
        Vector3 destination = targetObject.transform.position;
        destination.x = 0f;
        destination.y += height;
        destination.z += distance;
        transform.position = destination;
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            ExcecuteReBounding();
        }
    }
    

    void ExcecuteReBounding(Collision collision)
    {
        ContactPoint cp = collision.GetContact(0);
        Vector3 dir = Tr.position - cp.point;
        GetComponent<Rigidbody>().AddForce((dir).normalized * 300f);
    }
}
*/
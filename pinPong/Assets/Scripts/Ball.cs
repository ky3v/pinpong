using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 32.1F;
    private Rigidbody m_body;
    private bool isThrown = false;
    public float horizontalSpeed = 0.1F; /*좌우 조종시 이동 속도*/


    // Start is called before the first frame update
    void Start()
    {
        m_body = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        BallMovement();
    }

    void BallMovement()
    {
        if (!isThrown)
        {
            float xAxis = Input.GetAxis("Horizontal");
            Vector3 position = transform.position;
            position.x += xAxis * horizontalSpeed;
            transform.position = position;
        }

        if(!isThrown && Input.GetKeyDown(KeyCode.Space))
        {
            isThrown = true;
            m_body.isKinematic = false;
            m_body.velocity = new Vector3(0, 0, speed);
        }
    }
}

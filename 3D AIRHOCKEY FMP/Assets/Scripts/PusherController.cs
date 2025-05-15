using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 velocity;
    private Rigidbody rb;
    public float rightrestriction = 5f;
    public float leftrestriction = -5f;
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }

    void Update()
    {
        HandleMovement();
    }
    
    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * moveX;
        rb.velocity = new Vector3(move.x * speed, rb.velocity.y * Time.deltaTime);

        //Vector3 clampedPosition = rb.position;
       // clampedPosition.x = Mathf.Clamp(clampedPosition.x,leftrestriction,rightrestriction);
      //  rb.position = clampedPosition;
    }
}

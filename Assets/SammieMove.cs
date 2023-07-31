using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SammieMove : MonoBehaviour
{
    Rigidbody rigidBody;

    float speed = 5;
    // float jumpForce = 400;
    // bool isJumping = false;


    // Start is called before the first frame update
    void Start()
    {
        //rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) { // Left
            transform.position += -transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D)) { // Right
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.W)) { // Forward
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S)) { // Backward
             transform.position += -transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.E)) { // Rotate right
            transform.Rotate(new Vector3(0, 20 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.Q)) { // Rotate left
            transform.Rotate(new Vector3(0, -20 * Time.deltaTime, 0));
        }

        // if (Input.GetKey(KeyCode.Space)) { // jump
        //     if (!isJumping) 
        //     {
        //         isJumping = true;
        //         rigidBody.AddForce(transform.up * jumpForce);
        //     }
        // }
    }
}

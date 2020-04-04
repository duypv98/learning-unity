/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // Start is called before the first frame update
    /*void Start() {
        // Debug.Log("Hello, World !");
        // rb.useGravity = false;
        rb.AddForce(0, 200, 500);
    }*/

    // Update is called once per frame
    // FixedUpdate: using to mess with physics
    void FixedUpdate() {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}

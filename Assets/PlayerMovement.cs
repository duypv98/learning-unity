/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    /*void Start() {
        Debug.Log("Hello, World !");
        rb.useGravity = false;
        rb.AddForce(0, 200, 500);
    }*/

    // Update is called once per frame
    // FixedUpdate: using to mess with physics
    void FixedUpdate() {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0);
        }

    }
}

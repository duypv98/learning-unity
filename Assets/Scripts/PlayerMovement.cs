/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Reference to the Rigidbody component called "rb"
    public Rigidbody Rb;

    public float ForwardForce = 1000f;
    public float SidewaysForce = 500f;

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
        Rb.AddForce(0, 0, ForwardForce * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            Rb.AddForce(SidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            Rb.AddForce(-SidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}

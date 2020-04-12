using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement Movement;

    void OnCollisionEnter(Collision collision) {

        /* Debug.Log(collision.collider.name); */
        if (collision.collider.tag == "Obstacle") {
            Debug.Log("We hit an obstacle !");
            Movement.enabled = false;
        }
    }

}

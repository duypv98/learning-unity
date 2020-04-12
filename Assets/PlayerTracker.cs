using UnityEngine;

public class PlayerTracker : MonoBehaviour {
    // References to the Player
    public Transform Player;
    public Vector3 Offset;

    // Update is called once per frame
    void Update() {
        /* Debug.Log(Player.position); */
        /* this.transform.position = Player.position // FPP */
        this.transform.position = Player.position + Offset; // TPP
        /* This script is attached with the Main Camera, so that `this` is refers to the Main Camera.
        Actually, we can just write `transfrom` instead of `this.transform` */
    }
}

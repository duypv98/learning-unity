using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager Manager;

    void OnTriggerEnter(Collider other) {
        Manager.CompleteLevel();
    }
}

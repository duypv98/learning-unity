using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform Player;
    public Text ScoreText;

    // Update is called once per frame
    void Update() {
        /* Debug.Log(Player.position.z); */
        ScoreText.text = "Score: " + (Player.position.z + 45.0).ToString("0");
    }
}

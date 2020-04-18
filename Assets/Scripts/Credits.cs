using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {
    public void QuitGame() {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void PlayAgain() {
        SceneManager.LoadScene("Level01");
    }
}

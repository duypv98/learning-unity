﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool IsGameOver = false;

    public float RestartDelay = 1f;

    public GameObject CompleteLevelUI;

    public void CompleteLevel() {
        Debug.Log("LEVEL WON");
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (!IsGameOver) {
            IsGameOver = true;
            Debug.Log("GAME OVER");

            // Restart the game
            // RestartGame();
            Invoke("RestartGame", RestartDelay);
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

}

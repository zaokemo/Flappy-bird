using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Added for SceneManager

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverCanvas;

    private void Awake()
    {
        // Singleton pattern: check if instance already exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // If instance already exists, destroy this gameObject
            Destroy(gameObject);
            return;
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

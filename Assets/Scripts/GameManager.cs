using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject levelCompleteUI;
    public void EndGame()
    {
        Invoke("Restart", 2f);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        levelCompleteUI.SetActive(true);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}

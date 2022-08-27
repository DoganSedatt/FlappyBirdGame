using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOver,restart;
    public AudioSource soundSource;

    public void Score()
    {
        score++;
        scoreText.text = score.ToString();
        soundSource.Play();
    }
    public void Dead()
    {
        gameOver.SetActive(true);
        restart.SetActive(true);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
        
    }
}

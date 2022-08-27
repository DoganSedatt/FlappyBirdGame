using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuObject;
    public AudioSource source;
   
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
        source.Play();
        
    }
    public void QuitGame()
    {
        Debug.Log("Uygulamadan Çýkýldý");
        source.Play();
        Application.Quit();
    }
    public void SettingsButton()
    {
        mainMenuObject.SetActive(false);
    }
}

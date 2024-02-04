using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUIManagerScript : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject resumeButton;
    public GameObject menuButton;
    public GameObject pauseText;

    // Start is called before the first frame update
    void Start()
    {
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        pauseText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void pause()
    //{
       // Time.timeScale = 0f;
       // enemySpeed = 0f;
    //}

    public void pauseButtonClicked()
    {
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        menuButton.SetActive(true);
        pauseText.SetActive(true);

        //pause();
    }

    public void resumeButtonClicked()
    {
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        pauseText.SetActive(false);

        //Time.timeScale = 1.0f;
    }

    public void menuButtonClicked()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}

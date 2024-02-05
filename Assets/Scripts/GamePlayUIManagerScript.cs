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
    public GameObject playButton;
    public GameObject menuButton;
    public GameObject pauseText;
    public GameObject gameOverImage;
    public Text scoreText;
    public Text yourScoreText;
    public Text finalScore;

    private int score;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        isGameOver = false;

       
        InvokeRepeating("scoreUpdate", 1.0f, 0.2f);
        

        pauseButton.SetActive(true);
        playButton.SetActive(false);
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        pauseText.SetActive(false);
        gameOverImage.SetActive(false); 
        yourScoreText.gameObject.SetActive(false);
        finalScore.gameObject.SetActive(false); 

    }

    // Update is called once per frame
    void Update()
    {
        //score = score + 1;
        scoreText.text = "SCORE : " + score;

    }

    void scoreUpdate()
    {
        if( isGameOver == false)
        {
            score = score + 1;
        }
    }

    //void pause()
    //{
       // Time.timeScale = 0f;
       // enemySpeed = 0f;
    //}

    public void gameOver()
    {
        pauseButton.SetActive(false);
        playButton.SetActive(true);    
        resumeButton.SetActive(false);
        menuButton.SetActive(true);
        pauseText.SetActive(false);
        gameOverImage.SetActive(true);
        scoreText.gameObject.SetActive(false);
        yourScoreText.gameObject.SetActive(true);
        finalScore.text = score.ToString();
        finalScore.gameObject.SetActive(true);


    }

    public void playAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void pauseButtonClicked()
    {
        pauseButton.SetActive(false);
        playButton.SetActive(false);
        resumeButton.SetActive(true);
        menuButton.SetActive(true);
        pauseText.SetActive(true);
        gameOverImage.SetActive(false);
        yourScoreText.gameObject.SetActive(false);
        finalScore.gameObject.SetActive(false);

        //pause();
    }

    public void resumeButtonClicked()
    {

        
            pauseButton.SetActive(true);
            playButton.SetActive(false);
            resumeButton.SetActive(false);
            menuButton.SetActive(false);
            pauseText.SetActive(false);
            gameOverImage.SetActive(false);
            yourScoreText.gameObject.SetActive(false);
            finalScore.gameObject.SetActive(false);
        
        
        

            Time.timeScale = 1.0f;
    }

    

    public void menuButtonClicked()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public void pauseButtonClicked()
    {
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        menuButton.SetActive(true);
        pauseText.SetActive(true);
    }

    public void resumeButtonClicked()
    {
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        pauseText.SetActive(false);
    }
}

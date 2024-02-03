using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}

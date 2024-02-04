using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCarMovement : MonoBehaviour
{
    public float enemySpeed = 1f;
    public GamePlayUIManagerScript gamePlayUIManagerScript;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Time.timeScale == 1)
        {
            transform.Translate(new Vector3(0, 1, 0) * enemySpeed);
        }
    }

    public void pauseGame()
    {
        gamePlayUIManagerScript.pauseButtonClicked();
        enemySpeed = 0f;
        Debug.Log("game paused");
        Time.timeScale = 0f;
    }

    public void resumeGame()
    {
        gamePlayUIManagerScript.resumeButtonClicked();
        enemySpeed = 0.03f;
    }
}

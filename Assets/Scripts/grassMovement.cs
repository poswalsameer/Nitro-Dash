using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassMovement : MonoBehaviour
{

    public float grassSpeed;

    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2 (Time.time * (-grassSpeed), 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}

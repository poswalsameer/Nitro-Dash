using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnScript : MonoBehaviour
{
    public GameObject oppositeCar;
    public float oppositeCarPosition = 1.6f;
    void Start()
    {
        Vector3 carPosition = new Vector3 (Random.Range(0.3f, 1.6f), transform.position.y, transform.position.z);
        Instantiate(oppositeCar, carPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

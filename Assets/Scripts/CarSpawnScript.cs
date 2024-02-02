using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CarSpawnScript : MonoBehaviour
{
    public GameObject[] oppositeCar;
    public int carNumber;
    public float oppositeCarPosition = 1.6f;

    public float delayInCar = 2.5f;
    public float timer;
    void Start()
    {
        timer = delayInCar;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if( timer <= 0)
        {
            Vector3 carPosition = new Vector3(Random.Range(0.3f, 1.4f), transform.position.y, transform.position.z);
            carNumber= Random.Range(0, 2);
            Instantiate(oppositeCar[carNumber], carPosition, transform.rotation);
            timer = delayInCar;
        }
    }
}

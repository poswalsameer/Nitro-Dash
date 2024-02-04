using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCarSpawnScript : MonoBehaviour
{
    public GameObject[] frontCar;
    public int carNumber;
    public float delayInCar = 1.5f;
    public float timer;
    // Start is called before the first frame update
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
            Vector3 frontCarPosition = new Vector3(Random.Range(-1.4f, -0.4f), transform.position.y, transform.position.z);
            carNumber = Random.Range(0, 2);

             Instantiate(frontCar[carNumber], frontCarPosition, transform.rotation);
            
            timer = delayInCar;
        }
    }
}

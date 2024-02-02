using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCarSpawnScript : MonoBehaviour
{
    public GameObject frontCar;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 frontCarPosition = new Vector3 (Random.Range(-1.6f , -0.4f), transform.position.y, transform.position.z);
        Instantiate(frontCar, frontCarPosition, transform.rotation);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

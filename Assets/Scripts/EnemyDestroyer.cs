using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.tag == "EnemyFrontCar")
        {
            Destroy(collision.gameObject);
        }
        if( collision.gameObject.tag == "EnemyOppositeCar")
        {
            Destroy(collision.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

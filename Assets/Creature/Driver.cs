using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //  GIVING THE DRIVER A RANDOM DIRECTION
        rb.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * 2;
        // Giving the driver a random rotation
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));

    }

    // Update is called once per frame
    void Update()
    {
        // Every One min print speed
    if(Time.deltaTime%30==0){
        Debug.Log(rb.velocity.magnitude);
    }

    }
    
}

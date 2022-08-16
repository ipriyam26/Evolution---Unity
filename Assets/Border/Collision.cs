using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
private void OnCollisionEnter2D(Collision2D other) {

    Vector2 velocity = other.relativeVelocity;
    if(gameObject.name=="Vertical"){
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocity.x*-1, velocity.y);
    }
    if(gameObject.name=="Horizontal"){
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocity.x, velocity.y*-1);
    }
}
}

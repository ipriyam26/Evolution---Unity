using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
private void OnCollisionEnter2D(Collision2D other) {
    if(gameObject.name=="Vertical"){
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x*-1,rb.velocity.y);
    }
    if(gameObject.name=="Horizontal"){
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y*-1);
    }
}
}

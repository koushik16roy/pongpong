using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    Vector2 direction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.one.normalized;  // (1,1)
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("wall"))
        {
            direction.y = -direction.y;
        }
        if(collision.gameObject.CompareTag("player"))
        {
            speed += Random.Range(1f, 2f);
            direction.x = -direction.x;
        }
    }
}

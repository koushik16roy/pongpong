using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "player2")
        {
            MovePlayer(gameObject.name);
        }
        else if (gameObject.name == "player")
        {
            MovePlayer(gameObject.name);
        }
    }
    void MovePlayer(string player)
    {
        float moveY = Input.GetAxis(player) * speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x,Mathf.Clamp( transform.position.y + moveY,minY,maxY ));
    }
}

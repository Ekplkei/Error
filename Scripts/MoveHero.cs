using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero: MonoBehaviour
{
    private float movespeed = 5f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && (transform.position.y < 4.5)) transform.Translate(Vector2.up * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && (transform.position.y > -4.5)) transform.Translate(-Vector2.up * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && (transform.position.x > -4.5)) transform.Translate(-Vector2.right * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) && (transform.position.x < 4.5)) transform.Translate(Vector2.right * movespeed * Time.deltaTime);
    }
}

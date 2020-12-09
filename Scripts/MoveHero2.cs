using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero2 : MonoBehaviour
{
    private float movespeed = 5f;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < 4.5)) transform.Translate(Vector2.up * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > -4.5)) transform.Translate(-Vector2.up * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -4.5)) transform.Translate(-Vector2.right * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < 4.5)) transform.Translate(Vector2.right * movespeed * Time.deltaTime);
    }
}
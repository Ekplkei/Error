using UnityEngine;

public class MoveEnemies : MonoBehaviour
{
    int k;
    private void Start()
    {
        k = Random.Range(0, 8);
        Invoke("Start", 0.1f);
    }
    private void Update()
    {
        float movespeed = Random.Range(3f, 5f);
        if (k == 0 && (transform.position.y < 4.5)) transform.Translate(Vector2.up * movespeed * Time.deltaTime); //Up
        if (k == 1 && (transform.position.y > -4.5)) transform.Translate(Vector2.up * -movespeed * Time.deltaTime); // Down
        if (k == 2 && (transform.position.x > -4.5)) transform.Translate(Vector2.right * -movespeed * Time.deltaTime); // Left
        if (k == 3 && (transform.position.x < 4.5)) transform.Translate(Vector2.right * movespeed * Time.deltaTime); // Right
        if (k == 4 && (transform.position.y < 4.5) && (transform.position.x > -4.5))  // Up and Left
        {
            transform.Translate(Vector2.right * -movespeed * Time.deltaTime);
            transform.Translate(Vector2.up * movespeed * Time.deltaTime);
        }
        if (k == 5 && (transform.position.y < 4.5) && (transform.position.x < 4.5)) // Up and Right
        {
            transform.Translate(Vector2.up * movespeed * Time.deltaTime);
            transform.Translate(Vector2.right * movespeed * Time.deltaTime);
        }
        if (k == 6 && (transform.position.y > -4.5) && (transform.position.x > -4.5)) //Down and Left
        {
            transform.Translate(Vector2.up * -movespeed * Time.deltaTime);
            transform.Translate(Vector2.right * -movespeed * Time.deltaTime);
        }
        if (k == 7 && (transform.position.y > -4.5) && (transform.position.x < 4.5))
        {
            transform.Translate(Vector2.up * -movespeed * Time.deltaTime);
            transform.Translate(Vector2.right * movespeed * Time.deltaTime);
        }
    }
}

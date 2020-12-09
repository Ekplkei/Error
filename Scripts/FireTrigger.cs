using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    public bool kostil = false;
    public void Start()
    {
        Invoke("Kostil", 0.5f);
    }
    public void Kostil()
    {
        kostil = true;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Door") transform.position = new Vector2(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f));
        if (col.tag == "Player" && kostil) transform.position = new Vector3(-3, -7, 94);
    }
}

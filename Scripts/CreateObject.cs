using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject[] Fire = new GameObject[10];
    public GameObject[] Enemies = new GameObject[7];
    public GameObject Door;
    public GameObject Hero1;
    public GameObject Hero2;
    public GameObject Player2;
    public static int hard = 0;

    private void Start()
    {
        Player2.SetActive(false);
        Hero1.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
        Door.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
        for (int i = 0; i < Fire.Length; i++) Fire[i].transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
        for (int i = 0; i < Enemies.Length; i++) Enemies[i].transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
        if (Menu.level != 1)
        {
            Player2.SetActive(true);
            Hero2.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
        }
    }
}
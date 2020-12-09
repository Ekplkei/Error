using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Trigger1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HeroLives, Result;
    public GameObject[] Fire = new GameObject[10];
    public GameObject[] Enemy = new GameObject[7];
    public GameObject res, Door;
    public FireTrigger FT0, FT1, FT2, FT3, FT4, FT5, FT6, FT7, FT8, FT9;
    bool kostil = false, re_game = true, life = true;
    static int lives = 1;
    private void Start()
    {
        res.SetActive(false);
        Result.text = "";
        HeroLives.text = $"Жизни: {lives}";
        Invoke("Kostil", 0.5f);
    }
    private void Kostil()
    {
        kostil = true;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        res.GetComponent<Button>().onClick.AddListener(delegate { press(); });
        re_game = true;
        if (col.tag == "Door")
        {
            if (Menu.level != 2)
            {
                if (Menu.level != 4) Result.text = "Победа";
                else Result.text = "Игрок 2";
                res.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                Menu.hard++;
                if (Menu.hard == 2)
                {
                    Menu.hard = 0;
                    Result.text = "Победа";
                    res.SetActive(true);
                    Time.timeScale = 0;
                }
            }
            transform.position = new Vector3(-1, -7, 94);

        }
        if ((col.tag == "Enemy" || col.tag == "Fire") && kostil) lives--;
        if (lives == 0)
        {
            if (life) Menu.riv++;
            transform.position = new Vector3(-2, -7, 94);
            if (Menu.level == 1 || Menu.level == 2 || Menu.riv == 2)
            {
                Result.text = "Поражение";
                res.SetActive(true);
                HeroLives.text = $"Жизни: {lives}";
                Time.timeScale = 0;
                transform.position = new Vector3(-1, -7, 94);
            }
        }
    }
    public void press()
    {
        if (re_game)
        { // Без re_game идёт несколько проигрований функции
            lives = 1; HeroLives.text = $"Жизни: {lives}";
            Menu.hard = 0;
            Menu.riv = 0;
            Result.text = "";
            kostil = false; Start();
            FT0.kostil = false; FT1.kostil = false; FT2.kostil = false; FT3.kostil = false; FT4.kostil = false; FT5.kostil = false; FT6.kostil = false; FT7.kostil = false; FT8.kostil = false; FT9.kostil = false;
            FT0.Start(); FT1.Start(); FT2.Start(); FT3.Start(); FT4.Start(); FT5.Start(); FT6.Start(); FT7.Start(); FT8.Start(); FT9.Start();
            for (int i = 0; i < Fire.Length; i++) Fire[i].transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
            for (int i = 0; i < Enemy.Length; i++) Enemy[i].transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
            transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
            Door.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f), 94);
            Time.timeScale = 1;
            re_game = false;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[System.Serializable]
public class Menu : MonoBehaviour
{
    public static int level, hard = 0, riv = 0;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_One()
    {
        level = 1;
    }
    public void Level_Hardcore()
    {
        level = 2;
    }
    public void Level_Partnership()
    {
        level = 3;
    }
    public void Level_Rivalry()
    {
        level = 4;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Menu
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    // Levels
    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void LoadLevel02()
    {
        SceneManager.LoadScene("Level02");
    }
    public void LoadLevel03()
    {
        SceneManager.LoadScene("Level03");
    }
    public void LoadLevel04()
    {
        SceneManager.LoadScene("Level04");
    }
    public void LoadLevel05()
    {
        SceneManager.LoadScene("Level05");
    }
    public void LoadLevel06()
    {
        SceneManager.LoadScene("Level06");
    }
    public void LoadLevel07()
    {
        SceneManager.LoadScene("Level07");
    }
    public void LoadLevel08()
    {
        SceneManager.LoadScene("Level08");
    }
    public void LoadLevelInfinity()
    {
        SceneManager.LoadScene("LevelInfinity");
    }
}

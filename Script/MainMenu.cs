using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isEscapeToExit;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void MenuAwal()
    {
        SceneManager.LoadScene("MenuAwal");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }


}

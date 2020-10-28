using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public string[] levels;
    public void StartLevel()
    {
        int levelNumber = Random.Range(0, levels.Length);
        SceneManager.LoadScene(levels[levelNumber]);

    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Toturial()
    {
        SceneManager.LoadScene("CaseTutorial");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

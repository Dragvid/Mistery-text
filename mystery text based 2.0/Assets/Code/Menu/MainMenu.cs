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
        Debug.Log("quit");
    }
    public void Toturial()
    {
        Debug.Log("tutorial");
        SceneManager.LoadScene("CaseTutorial");
    }
}

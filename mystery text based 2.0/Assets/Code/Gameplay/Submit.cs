using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Submit : MonoBehaviour
{
    public GameObject[] boxes;
    public GameObject LevelEndRight;
    public GameObject LevelEndWrong;
    public string[] rightWho = new string[1];
    public string[] rightWhen = new string[1];
    public string[] rightHow = new string[1];
    private int answerCount = 0;
    private float percentage;

    public void OnClick()
    {
        
        int rightCounter = 0, correctBoxCounter=0;
        // 0-box who; 1-box when; 2- box how
        for (int i=0; i < boxes.Length; i++)
        {
            CountAnswers(i);
            //Debug.Log("on the box " + i + "there are " + answerCount + " answers");
            if (answerCount != rightWho.Length && i == 0)
            {
                LevelEndWrong.SetActive(true);
                /*Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);*/
                //Debug.Log("wrong");
            }
            if (answerCount != rightWhen.Length && i == 1)
            {
                LevelEndWrong.SetActive(true);
                /*Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);*/
                //Debug.Log("wrong");
            }
            if (answerCount != rightHow.Length && i == 2)
            {
                LevelEndWrong.SetActive(true);
                /*Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);*/
                //Debug.Log("wrong");
            }
            if (answerCount == rightWho.Length && i == 0 || answerCount == rightWhen.Length && i == 1 || answerCount == rightHow.Length && i == 2)
            {
                foreach (Transform child in boxes[i].transform)
                {
                    //Debug.Log("answer[" + i + "] =" + child.name);
                    if (i == 0)
                    {
                        for (int j = 0; j < rightWho.Length; j++)
                        {
                            if (rightWho[j] == child.name)
                            {
                                rightCounter++;
                                //Debug.Log("'" + child.name + "'" + " matches '" + rightWho[j] + "'");
                            }

                        }
                        percentage = (rightCounter * 1f / rightWho.Length) * 100f;
                        //Debug.Log("who's success percentage: " + percentage + "%");
                        if (percentage == 100)
                        {
                            //Debug.Log("correct box");
                            correctBoxCounter++;
                        }

                    }
                    if (i == 1)
                    {
                        for (int j = 0; j < rightWhen.Length; j++)
                        {

                            if (rightWhen[j] == child.name)
                            {
                                rightCounter++;
                                //Debug.Log("'" + child.name + "'" + " matches '" + rightWhen[j] + "'");
                            }

                        }
                        percentage = (rightCounter * 1f / rightWhen.Length) * 100f;
                        //Debug.Log("when's success percentage: " + percentage + "%");
                        if (percentage == 100)
                        {
                            Debug.Log("correct box");
                            correctBoxCounter++;
                        }
                    }
                    if (i == 2)
                    {
                        for (int j = 0; j < rightHow.Length; j++)
                        {

                            if (rightHow[j] == child.name)
                            {
                                rightCounter++;
                                //Debug.Log("'" + child.name + "'" + " matches '" + rightHow[j] + "'");
                            }

                        }
                        percentage = (rightCounter * 1f / rightHow.Length) * 100f;
                        //Debug.Log("when's success percentage: " + percentage + "%");
                        if (percentage == 100)
                        {
                            //Debug.Log("correct box");
                            correctBoxCounter++;
                        }
                    }
                }
                
                rightCounter = 0;
                answerCount = 0;
            }
        }
        if (correctBoxCounter == boxes.Length)
        {
            //Debug.Log("correct solution");
            LevelEndRight.SetActive(true);
        }
        else
        {
            LevelEndWrong.SetActive(true);
            //Debug.Log("wrong");
        }
    }

    private void CountAnswers(int box)
    {
        foreach (Transform child in boxes[box].transform)
        {
            answerCount++;
        }
    }
    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
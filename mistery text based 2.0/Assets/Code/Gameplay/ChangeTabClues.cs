using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeTabClues : MonoBehaviour
{
    public GameObject clueText;
    public GameObject clueImage;
    public Button buttonSelf;
    private bool state;

    private void Start()
    {
        state = true;
    }
    public void ChangeTab()
    {
        state = !state;
        //false for text true for images
        if (state)
        {
            TextTab();
        }
        else
        {
            ImagesTab();
        }
    }

    public void ImagesTab()
    {
        if (clueText.active == true)
        {
            clueText.SetActive(false);
        }
        clueImage.SetActive(true);
    }
    public void TextTab()
    {
        if (clueImage.active == true)
        {
            clueImage.SetActive(false);
        }
        clueText.SetActive(true);
    }
}

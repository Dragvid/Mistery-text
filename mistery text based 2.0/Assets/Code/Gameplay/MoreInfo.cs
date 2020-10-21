using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreInfo : MonoBehaviour
{
    public string info;
    public Text infoPanel;
    //public GameObject;
    public Image[] imageSlots;
    public Sprite[] imageClues;
    public void OnClick()
    {
        foreach(Image img in imageSlots)
        {
            img.sprite = null;
        }
        for(int i=0;i< imageClues.Length; i++)
        {
            imageSlots[i].sprite = imageClues[i];
        }
        infoPanel.text = info;
    }
}

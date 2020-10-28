using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler,IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;

    public Text text;
    public GameObject optionsScroll;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 posInicial;


    private void Start()
    {
        posInicial = transform.position;
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup= GetComponent<CanvasGroup>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .3f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        gameObject.transform.SetParent(canvas.transform);
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //arranjar isto
        if (gameObject.transform.parent.tag == "DropBox")
        {
            Debug.Log(gameObject.name+" is in the box");
            if (gameObject.tag == "Word")
            {
                text.color = Color.blue;
            }
        }
        else
        {
            if (gameObject.tag == "Word")
            {
                text.color = Color.white;
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //gameObject.transform.SetParent(canvas.transform);

    }
    public void OnDrop(PointerEventData eventData)
    {
        //gameObject.transform.SetParent(canvas.transform);
        /*if(gameObject.transform.parent.name == "Canvas"){
            Debug.Log("pos errada");
            gameObject.transform.position = posInicial;
        }*/
    }
}

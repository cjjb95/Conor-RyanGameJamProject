using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragFunction : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private RectTransform OriginalTransform = new RectTransform();
    private CanvasGroup canvasGroup;
    public void OnBeginDrag(PointerEventData eventData)
    {
     //  Debug.Log("Begin Drag");
        canvasGroup.alpha = GameManager.variables.alphaMin;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("Drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; 
    }

    public void OnDrop(PointerEventData eventData)
    {
      
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       // Debug.Log("End Drag");
        canvasGroup.alpha = GameManager.variables.alphaMax;
        canvasGroup.blocksRaycasts = true;
        rectTransform.anchoredPosition = GameManager.deck.GetComponent<RectTransform>().anchoredPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
     
    }

    // Start is called before the first frame update
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        OriginalTransform = rectTransform;
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

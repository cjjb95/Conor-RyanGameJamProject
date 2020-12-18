using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GeographySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Card Dropped");
        if (eventData.pointerDrag != null) {
           
            eventData.pointerDrag.transform.SetParent(this.gameObject.transform, false);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =  GetComponent<RectTransform>().anchoredPosition - GetComponent<RectTransform>().anchoredPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

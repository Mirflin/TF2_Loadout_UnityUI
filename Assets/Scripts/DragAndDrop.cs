using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    private string name;
    private GameObject obj;
    public Canvas canv;
    private Vector3 mousePosition;

    void Start()
    {
        rTransform = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData data)
    {
        name = data.pointerEnter.transform.name;
        obj = data.pointerEnter;
        Debug.Log("Clicked on the object!");
    }
    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Drag starts!");
    }

    public void OnDrag(PointerEventData data)
    {
        mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,-273);
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0 + rTransform.rect.width / 2, Screen.width - rTransform.rect.width / 2);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0 + rTransform.rect.height / 2, Screen.height - rTransform.rect.height / 2);

        rTransform.position = mousePosition;
        //Debug.Log("x = " + mousePosition.x + "\n y = " + mousePosition.y);
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("Drag end!");
    }

}

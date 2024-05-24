using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    public Canvas canv;

    void Start()
    {
        rTransform = GetComponent<RectTransform>();

    }
    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Clicked on the object!");
    }

    float distanceBetCam = 0;
    public void OnDrag(PointerEventData data)
    {
        Vector2 touchPosition = data.position;

       
        Vector3 touchPositionInWorld = Camera.main.ScreenToWorldPoint(
            new Vector3(
                touchPosition.x,
                touchPosition.y,
                distanceBetCam)
        );

       
        transform.position = touchPositionInWorld;
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Drag Begin!");

        distanceBetCam = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    public void OnEndDrag(PointerEventData data)
    {

    }

}

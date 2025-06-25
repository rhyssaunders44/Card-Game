using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardInHand : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 positionInHand;
    Quaternion rotationInHand;
    public static bool cardBeingDragged = false;
    int previousOrderLayer;
    private SpriteRenderer cardSpriteRenderer;

    void OnEnable()
    {
        cardSpriteRenderer = transform.Find("image").GetComponent<SpriteRenderer>();
        Debug.Log("check");
    }
    
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        if (!cardBeingDragged)
        {
            cardBeingDragged = true;
            mousePosition = Input.mousePosition - GetMousePos();
        }
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition-mousePosition);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void OnMouseUp()
    {
        cardBeingDragged = false;
        SnapCardBackIntoPosition();
    }

    private void OnMouseEnter()
    {
        if (!cardBeingDragged) {
            PeekCard();
        }
    }

    private void OnMouseExit()
    {
        SnapCardBackIntoPosition();
    }

    public void PeekCard() {
        positionInHand = transform.position;
        rotationInHand = transform.rotation;
        previousOrderLayer = cardSpriteRenderer.sortingOrder;
        transform.position = new Vector3(transform.position.x, transform.parent.position.y + 1, transform.parent.position.z - 1);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        cardSpriteRenderer.sortingOrder = 100;
    }

    public void SnapCardBackIntoPosition() {
        transform.position = positionInHand;
        transform.rotation = rotationInHand;
        cardSpriteRenderer.sortingOrder = previousOrderLayer;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    public List<GameObject> cardsInHand = new List<GameObject>();
    public GameObject cardObject;
    private GameObject newCard;
    public int testingNumberOfCardsToAdd;
    public float maxArcLength;
    public float arcRadius;
    private float angleBetweenCards;
    public float maxAngleBetweenCards;
    private float currentAngle;
    private float cardsInHandBeforeCompression;
    
    // Start is called before the first frame update
    void Start()
    {
        cardsInHandBeforeCompression = Mathf.Floor(maxArcLength / maxAngleBetweenCards + 1);
    }

    public void AddCardToHand()
    {
        newCard = Instantiate(cardObject, transform);
        newCard.transform.Find("image").GetComponent<SpriteRenderer>().sortingOrder = cardsInHand.Count;
        cardsInHand.Add(newCard);
        UpdateCardPositions();
    }

    public void UpdateCardPositions()
    {
        angleBetweenCards = Mathf.Min(maxArcLength / (cardsInHand.Count - 1), maxAngleBetweenCards);

        if (cardsInHand.Count < cardsInHandBeforeCompression)
        {
            currentAngle = -angleBetweenCards * ((float) cardsInHand.Count - 1)/2 + 90;
        }
        else
        {
            currentAngle = -maxArcLength/2 + 90;
        }

        foreach (GameObject card in cardsInHand)
        {
            card.transform.localPosition = new Vector3(arcRadius * Mathf.Cos(Mathf.Deg2Rad * currentAngle), arcRadius * Mathf.Sin(Mathf.Deg2Rad * currentAngle) - arcRadius, 0);
            card.transform.rotation = Quaternion.Euler(0, transform.rotation.y - 2, -currentAngle - 90);
            currentAngle += angleBetweenCards;
        }
    }
}

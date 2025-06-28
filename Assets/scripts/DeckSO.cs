using UnityEngine;

[CreateAssetMenu(fileName = "DeckSO", menuName = "Scriptable Objects/DeckSO")]
public class DeckSO : ScriptableObject
{
    public CardManager.Faction faction;
    public int[] cardCounts;
    public CardSO[] uniqueCards;
}

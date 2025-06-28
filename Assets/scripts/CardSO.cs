using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "Scriptable Objects/CardSO")]
public class CardSO : ScriptableObject
{
    public CardManager.Faction cardFaction;
    public int baseStrength;
    public int baseDefense;
    public CardManager.CardAbilities[] cardAbilities;
    public CardManager.CardType[] cardTypes;



}

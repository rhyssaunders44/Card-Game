using System;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public enum CardAbilities
    {
        Assist, Bolster, Bulk, Charge
    }

    public enum CardType
    {
        Infantry, Cavalry, Holy
    }

    public enum Faction
    {
        any, bingus, aboba
    }

    public List<DeckSO> decks;
    
}

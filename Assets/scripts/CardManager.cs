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

    public enum BonusDuration
    {
        temp, perma
    }

    public List<DeckSO> decks;


    public struct BonusStat
    {
        public BonusStat(int _value, int _statIndex, BonusDuration _duration, CardAbilities _source)
        {
            value = _value;
            statIndex = _statIndex;
            duration = _duration;
            source = _source;
        }
        public int value;
        public int statIndex;
        public BonusDuration duration;
        public CardAbilities source;

    }

}


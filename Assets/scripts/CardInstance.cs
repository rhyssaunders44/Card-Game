using System.Collections.Generic;
using UnityEngine;    
public class CardInstance : MonoBehaviour
{
    public int[] visibleStats = { 0 , 0 }; //UwU

    public List<CardManager.BonusStat> bonusStatValues;

    public CardSO cardBase;

    public void AddBonus(CardManager.BonusStat _addedBonus)
    {
        bonusStatValues.Add(_addedBonus);
        SumStats();
        //UpdateUI();
    }

    void SumStats()
    {
        visibleStats = new int[]{cardBase.baseStrength, cardBase.baseDefense};

        foreach (CardManager.BonusStat bonus in bonusStatValues)
        {
            visibleStats[bonus.statIndex] += bonus.value;
        }   
        Debug.Log($"{cardBase.name} visible Stats Updated! {visibleStats}"); 
    }
}

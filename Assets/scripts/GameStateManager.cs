using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum Phases
    {
        prep, whatever, res
    }

    public Player[] players;

    public GameObject[][] playerField;
    public GameObject[] column;

    void Awake(){
    
        
    }
}

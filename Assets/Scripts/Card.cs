using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject North, East, South, West;
    public CardType type;
    public GameObject front;
    public bool played;
    int PlayerID;

    
    // Start is called before the first frame update
    void Start()
    {
        switch (type)
        {
            case CardType.Location:
                Debug.Log("Do something");
                break;
            case CardType.Trap:
                Debug.Log("Do something");
                break;
            case CardType.Equip:
                Debug.Log("Do something");
                break;
            case CardType.Ritual:
                Debug.Log("Do something");
                break;
            default:
                Debug.Log("Error, card has no assigned type");
                break;

        }
    }

    public void Drawn(Player player)
    {
        PlayerID = player.PlayerID;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
public enum CardType {Location, Trap, Equip, Ritual}
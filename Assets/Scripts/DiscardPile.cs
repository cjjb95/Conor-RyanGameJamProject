using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscardPile : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Card> CardList;
    public Text NoOfCards;
    void Start()
    {
        GameManager.discardPile = this;
        UpdateNoOfCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public List<Card> RefreshCards()
    {
        List<Card> clone = CardList;
        CardList.Clear();
        UpdateNoOfCards();
        return clone;
    
    }
    void UpdateNoOfCards()
    {
        NoOfCards.text = CardList.Count.ToString();
    }
}

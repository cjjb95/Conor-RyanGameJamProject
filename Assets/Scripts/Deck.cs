using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    public List<Card> CardList;
    public Text NoOfCards;
    Card clone;
    void Start()
    {
        
        GameManager.deck = this;
        Shuffle();
        foreach(Card c in CardList)
        {
            clone = Instantiate(c, new Vector3(0, 0, 0), Quaternion.identity);
            clone.transform.SetParent(this.gameObject.transform, false);
        }
        UpdateNoOfCards();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void Shuffle()
    {
        for (int i = 0; i < CardList.Count; i++)
        {
            Card temp = CardList[i];
            int randomIndex = Random.Range(i, CardList.Count);
            CardList[i] = CardList[randomIndex];
            CardList[randomIndex] = temp;
        }

    }

    public Card Draw()
    {
        if (CardList.Count == 0)
        {
            CardList = GameManager.discardPile.RefreshCards();
            Shuffle();
        }
        
        clone = CardList[0];
        CardList.RemoveAt(0);

        UpdateNoOfCards();
        return clone;
    
    }
    void UpdateNoOfCards()
    {
        NoOfCards.text = CardList.Count.ToString();
    }
}

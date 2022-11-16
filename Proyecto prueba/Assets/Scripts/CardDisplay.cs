using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card myCard;

    public Text cardNameText, CardCostText, CardAttackText, CardDefenceText, CardDescriptionText;

    public Image cardArtWork;

    private void Start()
    {
        cardNameText.text = myCard.cardName;
        CardCostText.text = myCard.cardCost.ToString();
        CardAttackText.text = myCard.cardAttack.ToString();
        CardDefenceText.text = myCard.cardDefense.ToString();
        CardDescriptionText.text = myCard.cardDescription;

        cardArtWork.sprite = myCard.cardArt;
    }
}
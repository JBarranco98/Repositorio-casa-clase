using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        CuentaMonedas counter = playerObject.GetComponent<CuentaMonedas>();
        counter.GetCoins(amountToGive);
        gameObject.SetActive(false);
    }
}
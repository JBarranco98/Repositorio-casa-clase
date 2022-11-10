using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerHealth : Health
{
    public Image deathScreen;
    public float timeToFade = 3;

    public override void Die()
    {
        deathScreen.DOFade(1, timeToFade);
    }
}
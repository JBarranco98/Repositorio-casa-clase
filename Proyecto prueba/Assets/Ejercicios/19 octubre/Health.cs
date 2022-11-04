using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Text healthText;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        if (healthText != null)
        {
            healthText.text = currentHealth.ToString();
        }

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log("He recibido daño, me quedan " + currentHealth + " puntos de vida.");
        }
    }

    public virtual void Die()
    {
    }
}
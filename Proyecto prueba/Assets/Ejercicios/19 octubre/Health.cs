using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Image healthBar;

    public void UpdateHealthBar()
    {
        healthBar.fillAmount = Mathf.InverseLerp(0, MaxHealth, currentHealth);
    }

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            Debug.Log("He recibido daño, me quedan " + currentHealth + " puntos de vida.");
        }
        UpdateHealthBar();
    }

    public virtual void Die()
    {
    }
}
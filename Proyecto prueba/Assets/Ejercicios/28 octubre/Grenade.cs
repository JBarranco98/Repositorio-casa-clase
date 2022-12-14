using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float timeToExplode = 5;

    private bool hasExploded = false;

    public GameObject explosionParticlesPrefab;

    public float explosionRadius = 5f;

    public float explosionsForce = 1000;

    private void Update()
    {
        timeToExplode -= Time.deltaTime;

        if (timeToExplode < 0 && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    private void Explode()
    {
        GameObject explosionEffect = Instantiate(explosionParticlesPrefab, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rb = colliders[i].GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionsForce, transform.position, explosionRadius);
            }
        }

        Destroy(explosionEffect, 2f);
        Destroy(gameObject);
    }
}
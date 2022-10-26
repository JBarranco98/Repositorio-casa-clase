using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject projectilePrefab;

    public float timeToShoot = 1;
    private float timeSinceLastShot = 0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot >= timeToShoot)
        {
            Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
            timeSinceLastShot = 0;
        }
    }
}
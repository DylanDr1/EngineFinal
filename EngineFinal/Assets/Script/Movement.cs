using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float projectileSpeed = 20f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireProjectile();
        }
    }
    public void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);


        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * projectileSpeed;
        }

        Destroy(projectile, 3f);
        
    }
}

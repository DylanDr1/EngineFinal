using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{
    public float moveSpeed;


    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            Destroy(gameObject);
        }
    }
}

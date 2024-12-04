using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    private void Start()
    {
        ObjectPool.Instance.InitializePool(spawnPoints.Length);
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject lantern = ObjectPool.Instance.GetLantern();
            if (lantern != null)
            {
                lantern.transform.position = spawnPoint.position;
                lantern.SetActive(true);
            }
        }
    }
}
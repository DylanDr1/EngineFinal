using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;
    public GameObject Prefab;
    private GameObject[] Objects;
    private int currentIndex = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void InitializePool(int poolSize)
    {
        Objects = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            Objects[i] = Instantiate(Prefab);
            Objects[i].SetActive(false);
        }
    }

    public GameObject GetLantern()
    {
        GameObject prefab = Objects[currentIndex];
        currentIndex = (currentIndex + 1) % Objects.Length;
        return prefab;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClassLibrary1;

public class ColourChange : MonoBehaviour
{
    public GameObject TargetObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ColorCycle.ChangeColor(TargetObject);
        }
    }
}


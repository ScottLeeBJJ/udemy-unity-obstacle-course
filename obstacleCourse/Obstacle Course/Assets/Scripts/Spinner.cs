using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpin = 0;
    [SerializeField] float ySpin = 0.5f;
    [SerializeField] float zSpin = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpin,ySpin,zSpin);
    }
}

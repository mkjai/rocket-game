using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] float xValue;
    [SerializeField] float yValue;
    [SerializeField] float zValue;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue * Time.deltaTime, yValue * Time.deltaTime, zValue * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _spinSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up, _spinSpeed * Time.deltaTime);
    }
}

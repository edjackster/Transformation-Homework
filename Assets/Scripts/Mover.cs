using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 direction = transform.forward * _speed * Time.deltaTime;
        transform.Translate(direction);
    }
}

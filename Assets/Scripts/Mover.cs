using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.forward * _speed * Time.deltaTime;
        transform.Translate(direction);
    }
}

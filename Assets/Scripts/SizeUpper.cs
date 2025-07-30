using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUpper : MonoBehaviour
{
    [SerializeField] private float _resizeSpeed;

    private void Update()
    {
        transform.localScale += transform.localScale * _resizeSpeed * Time.deltaTime;
    }
}

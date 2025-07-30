using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUpper : MonoBehaviour
{
    [SerializeField] private float _resizeSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.localScale += transform.localScale * _resizeSpeed * Time.deltaTime;
    }
}

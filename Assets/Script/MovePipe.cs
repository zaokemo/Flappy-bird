using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float _speed = 0.65f;

    private void Update()
    {
        transform.position -= Vector3.right * _speed * Time.deltaTime;
    }
}

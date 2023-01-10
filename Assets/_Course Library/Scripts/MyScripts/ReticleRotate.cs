using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotate : MonoBehaviour
{
    [SerializeField] private Vector3 rotatione;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotatione * _speed * Time.deltaTime);
    }
}

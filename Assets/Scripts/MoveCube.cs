using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private int _normalX;
    private int _normalZ;

    private void Start()
    {
        _normalX = Random.Range(-1, 2);
        _normalZ = Random.Range(-1, 2);

        if (_normalX == _normalZ && _normalZ == 0) 
        {
            _normalZ = 1;
        }
    }

    void Update()
    {
        if (Vector3.Distance(Vector3.zero, transform.position) < Parametrs.Distamce)
        {
            transform.position = new Vector3(transform.position.x + Parametrs.Speed * Time.deltaTime * _normalX, transform.position.y, transform.position.z + Parametrs.Speed * Time.deltaTime * _normalZ);
        }
        else Destroy(gameObject);
    }
}

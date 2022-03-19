using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _cubePrefab;

    private GameObject _cube;

    public void StartSpawn() 
    {
        StopAllCoroutines();
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn() 
    {
        _cube = Instantiate(_cubePrefab) as GameObject;
        _cube.transform.position = Vector3.zero;

        yield return new WaitForSeconds(Parametrs.TimeSpawn);

        StartCoroutine(Spawn());
    }
}

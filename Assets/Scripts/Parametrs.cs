using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Parametrs : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _seedText;

    [SerializeField]
    private TMP_InputField _timeSpawnText;

    [SerializeField]
    private TMP_InputField _distanceText;

    private static int _speed;
    public static int Speed => _speed;

    private static int _timeSpawn;
    public static int TimeSpawn => _timeSpawn;

    private static int _distance;
    public static int Distamce => _distance;

    public void Initialization() 
    {
        if (string.IsNullOrEmpty(_seedText.text))
        {
            _seedText.text = "1";
            _speed = 1;
        }
        else _speed = Convert.ToInt32(_seedText.text);

        if (string.IsNullOrEmpty(_timeSpawnText.text))
        {
            _timeSpawn = 1;
            _timeSpawnText.text = "2";
        }
        else _timeSpawn = Convert.ToInt32(_timeSpawnText.text);

        if (string.IsNullOrEmpty(_distanceText.text))
        {
            _distance = 5;
            _distanceText.text = "5";
        }
        else _distance = Convert.ToInt32(_distanceText.text);
    }
}

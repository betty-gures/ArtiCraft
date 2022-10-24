using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ResetCanPositions : MonoBehaviour
{
    public List<GameObject> balls;
    List<Vector3> initialPositionsBalls = new List<Vector3>();
    
    private void Start()
    {
        Invoke( "SaveInitialPositions" ,5); //gave some time for objects to fall on table and sit still
    }

    void SaveInitialPositions()
    {
        for (var i = 0; i < balls.Count; i++)
        {
            initialPositionsBalls.Add(balls[i].transform.position);
        }
    }

    public void ResetPositions()
    {
        for (var i = 0; i < balls.Count; i++)
        {
            balls[i].transform.position = initialPositionsBalls[i];
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class ResetCanPositions : MonoBehaviour
{
    public List<GameObject> cans;
    public List<GameObject> balls;
    List<Vector3> initialPositionsCans = new List<Vector3>();
    List<Vector3> initialPositionsBalls = new List<Vector3>();
    Quaternion initialRotationCans;
    [SerializeField] private TextMeshProUGUI _scoreText;
    public int _score=0;
    
    private void Start()
    {
        Invoke( "SaveInitialPositions" ,5); //gave some time for objects to fall on table and sit still

    }

    void SaveInitialPositions()
    {
        initialRotationCans = cans[0].transform.rotation;

        for (var i = 0; i < cans.Count; i++)
        {
            initialPositionsCans.Add(cans[i].transform.position);
        }
        for (var i = 0; i < balls.Count; i++)
        {
            initialPositionsBalls.Add(balls[i].transform.position);
        }
    }

    public void ResetPositions()
    {
        _score = 0;
        _scoreText.text = _score.ToString();
        for (var i = 0; i < cans.Count ; i++)
        {
            ChangeKinematic(cans[i],true);
            cans[i].transform.position = initialPositionsCans[i];
            cans[i].transform.rotation = initialRotationCans;
            ChangeKinematic(cans[i],false);
            
        }
        
        for (var i = 0; i < balls.Count; i++)
        {
            ChangeKinematic(balls[i],true);
            balls[i].transform.position = initialPositionsBalls[i];
            ChangeKinematic(balls[i],false);
        }

    }

    private void ChangeKinematic(GameObject gameObject, bool boolean)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = boolean;
    }
}

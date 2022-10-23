using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] ResetCanPositions _resetCanPositions;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Can")
            return;
        
        else if (other.gameObject.tag == "Can");
        {
            _resetCanPositions._score++;
            _scoreText.text = _resetCanPositions._score.ToString();
            
            if (_resetCanPositions._score >= 6)
            {
                _scoreText.text = "You Won";
            }
        }
    }
}

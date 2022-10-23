using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DuckScore : MonoBehaviour
{
    public int Score;
    [SerializeField] private TextMeshProUGUI _duckScoreText;
    [SerializeField] private DuckAnimation[] _duckAnimation;
    
    public void IncScore()
    {
        
        Score ++;
        _duckScoreText.text = Score.ToString();
        if (Score == 2)
        {
            _duckScoreText.text = "You Won!";
        }

    }

    public void Reset()
    {
        Score = 0;
        _duckScoreText.text = "0";
        foreach (var duckAnimation in _duckAnimation)
        {
            duckAnimation.isHit = false;
            duckAnimation.ResetRotation();
        }
        
    }
}

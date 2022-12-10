using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bird.ScoreChanged += OnScoreChange;
    }

    private void OnDisable()
    {
        _bird.ScoreChanged -= OnScoreChange;
    }

    private void OnScoreChange(int score)
    {
        _score.text = "Score: \n" + score.ToString();
    }
}

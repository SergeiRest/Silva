using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
	[SerializeField] private Text _scoreText;
	[SerializeField] private PlayerStats _playerStats;
    void Start()
    {
		_scoreText.text = "Score: " + _playerStats.Points;
		_playerStats.OnPointsValueChanged += AddPoint;
    }

	private void AddPoint()
	{
		_scoreText.text = $"Score: {_playerStats.Points}";
	}
}
